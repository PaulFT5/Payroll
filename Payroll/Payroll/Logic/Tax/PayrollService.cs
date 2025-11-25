using System;
using System.Collections.Generic;

namespace Payroll.Logic
{
    public class PayrollService
    {
        private readonly int _payday;
        private readonly ITaxPolicy _taxPolicy;
        private readonly Company _company;
        private readonly int maxMissedDays;
        private readonly int CompanyMoneyDay = 3;

        public PayrollService(ITaxPolicy taxPolicy, Company company, int payday = 7)
        {
            _taxPolicy = taxPolicy;
            _company = company;
            _payday = payday;
            maxMissedDays = 28;

            TimeManager.OnDateChanged += OnDateChange;
        }

        public void OnDateChange(DateTime date)
        {
            var employees = EmployeeManager.Employees;

            // ---- Daily work simulation ----
            foreach (var e in employees)
            {
                if (EmployeeBehaviour.MissedADay() && e.MissedDays < maxMissedDays)
                {
                    e.MissedDays++;
                }
                else
                {
                    e.WorkedOneDay();
                    e.WorkedExtraHours += EmployeeBehaviour.WorkedExtraChance();
                }
                
                e.WorkedExtraPay = e.WorkedExtraHours * e.Salary * 1.5;
            }
            
            if (date.Day == CompanyMoneyDay)
            {
                _company.RecieveMonthlyMoney();
                Console.WriteLine($"[DEBUG] Company received monthly income. Balance: {_company.MoneyInCompany}");
            }
            
            if (date.Day == _payday)
            {
                Console.WriteLine("\n========== PAYDAY ==========");

                int monthIndex = date.Month - 1;
                double totalMoneyForEmployees = 0;
                
                foreach (var e in employees)
                {
                    if (!e.Paid[monthIndex])
                    {
                        totalMoneyForEmployees += e.GetEmployeeMonthlySalary();
                    }
                }

                Console.WriteLine($"[DEBUG] Total salaries this payday: {totalMoneyForEmployees}");
                Console.WriteLine($"[DEBUG] Company money before withdrawal: {_company.MoneyInCompany}");
                
                _company.Withdraw((int)totalMoneyForEmployees);

                Console.WriteLine($"[DEBUG] Company money after withdrawal: {_company.MoneyInCompany}");
                
                foreach (var e in employees)
                {
                    if (!e.Paid[monthIndex])
                    {
                        e.Pay(_taxPolicy);
                        e.Paid[monthIndex] = true;
                    }
                }
                
                foreach (var e in employees)
                {
                    if (e.Paid[monthIndex])
                    {
                        e.WorkedDays = 0;
                        e.WorkedExtraHours = 0;
                    }
                }

                Console.WriteLine("========== END PAYDAY ==========\n");
            }

            
            if (date.Day == 1 && date.Month == 1)
            {
                foreach (var e in employees)
                {
                    e.MissedDays = 0;
                }
            }
            EmployeeManager.SaveEmployees();
        }
    }
}
