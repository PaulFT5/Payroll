using System;
using System.Collections.Generic;

namespace Payroll2.Logic;

public class PayrollService
{
    private readonly int _payday;
    private readonly ITaxPolicy _taxPolicy;

    public PayrollService(ITaxPolicy taxPolicy, int payday = 7)
    {
        _taxPolicy = taxPolicy;
        _payday = payday;

        // Subscribe to TimeManager events
        TimeManager.OnDateChanged += OnDateChange;
    }

    public void OnDateChange(DateTime date)
    {
        // Get the current employees list at runtime
        var employees = EmployeeManager.Employees;
        
        foreach (var e in employees)
        {
            e.WorkedOneDay();
            Console.WriteLine($"[DEBUG] {e.Id} WorkedDays: {e.WorkedDays}");

            // Pay on payday
            if (date.Day == _payday)
            {
                int monthIndex = date.Month - 1;
                if (!e.Paid[monthIndex])
                {
                    e.Pay(_taxPolicy);
                    e.Paid[monthIndex] = true;
                    Console.WriteLine($"[DEBUG] {e.Id} PAID - WorkedDays before save: {e.WorkedDays}");
                }
            }
        }

        // Save BEFORE resetting
        Console.WriteLine($"[DEBUG] Saving on {date:yyyy-MM-dd}");
        EmployeeManager.SaveEmployees();

        // Reset WorkedDays ONLY on payday, AFTER saving
        if (date.Day == _payday)
        {
            foreach (var e in employees)
            {
                int monthIndex = date.Month - 1;
                if (e.Paid[monthIndex])
                {
                    e.WorkedDays = 0;
                    Console.WriteLine($"[DEBUG] {e.Id} reset to 0 after payday");
                }
            }
            // Save again after reset so next day starts fresh
            EmployeeManager.SaveEmployees();
        }
    }
}