using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 

namespace Payroll.Logic
{
    public class PayrollService
    {
        private const int MaxMissedDays = 28;
        private const int CompanyMoneyDay = 3;
        private const double OvertimeMultiplier = 1.5;

        private readonly int _payday;
        private readonly ITaxPolicy _taxPolicy;
        private readonly Company _company;
        

        public PayrollService(ITaxPolicy taxPolicy, Company company, int payday = 7)
        {
            _taxPolicy = taxPolicy;
            _company = company;
            _payday = payday;

            TimeManager.OnDateChanged += OnDateChange;
        }

        public void OnDateChange(DateTime date)
        {
            SimulateDailyWork();
            
            if (date.Day == CompanyMoneyDay)
            {
                ProcessCompanyIncome();
            }
            
            if (date.Day == _payday)
            {
                ProcessPayday(date);
            }
            
            EmployeeManager.SaveEmployees();
        }

        private void SimulateDailyWork()
        {
            foreach (var e in EmployeeManager.Employees)
            {
                if (EmployeeBehaviour.MissedADay() && e.MissedDays < MaxMissedDays)
                {
                    e.MissedDays++;
                }
                else
                {
                    e.WorkedOneDay();
                    e.WorkedExtraHours += EmployeeBehaviour.WorkedExtraChance();
                }
                
                e.WorkedExtraPay = e.WorkedExtraHours * e.Salary * OvertimeMultiplier;
            }
        }

        private void ProcessCompanyIncome()
        {
            _company.RecieveMonthlyMoney();
            Console.WriteLine($"[FINANCE] Company received income. Balance: {_company.MoneyInCompany}");
        }

        private void ProcessPayday(DateTime date)
        {
            Console.WriteLine("\n========== PAYDAY STARTED ==========");

            var employees = EmployeeManager.Employees;
            
            string paymentKey = $"{date.ToString("MMMM", CultureInfo.InvariantCulture)}";
            
            var unpaidEmployees = employees
                .Where(e => !e.Paid.GetValueOrDefault(paymentKey))
                .ToList();

            if (unpaidEmployees.Count == 0)
            {
                Console.WriteLine("[INFO] Everyone is already paid for this month.");
                return;
            }
            
            double totalRequired = unpaidEmployees.Sum(e => e.GetEmployeeMonthlySalary());

            Console.WriteLine($"[FINANCE] Total Salaries: {totalRequired} | Current Balance: {_company.MoneyInCompany}");
            
            try
            {
                _company.Withdraw((int)totalRequired);
                Console.WriteLine($"[FINANCE] Withdrawal successful. New Balance: {_company.MoneyInCompany}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"[CRITICAL] BANKRUPTCY ALERT: {ex.Message}");
                return; 
            }
            
            foreach (var e in unpaidEmployees)
            {
                e.Pay(_taxPolicy);
                
                e.Paid[paymentKey] = true;
                
                e.WorkedDays = 0;
                e.WorkedExtraHours = 0;
            }

            Console.WriteLine("========== PAYDAY COMPLETE ==========\n");
        }
    }
}