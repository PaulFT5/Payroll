using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Payroll.Logic;

public class Employee
{
    private static int _idCounter = 0;
    
    public string Id { get; set; }
    public int Salary { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public workHoursEnum WorkHours { get; set; }
    
    public int ExpectedSalary { get; set; }
    
    public int WorkedExtraHours { get; set; }
    
    public double WorkedExtraPay { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public contractTypeEnum ContractType { get; set; }

    public int MissedDays { get; set; }
    public int WorkedDays { get; set; }
    public double SalariesTotalBrut { get; set; }
    public double SalariesTotalNet { get; set; }
    public DateTime HiringDate { get; set; }
    public List<bool> Paid { get; set; } 

    public Employee() { } // parameterless constructor for JSON

    public Employee(int salary, workHoursEnum workHours, contractTypeEnum contractType)
    {
        Id = $"EMP{++_idCounter:D6}";//
        ContractType = contractType;// extern/intern
        Salary = salary;// per hour
        WorkHours = workHours;//4hr/6hr/fulltime
        ExpectedSalary = 20 * (int)workHours * salary; // expected based only on salary
        WorkedDays = 0; //
        WorkedExtraHours = 0;//
        WorkedExtraPay = 0;// the amount he gets for extra work
        MissedDays = 0;// max to 28, resets every year
        SalariesTotalBrut = 0;// total with extra hours
        SalariesTotalNet = 0; //after tax
        HiringDate = TimeManager.MockDate;
        Paid = new List<bool>(new bool[12]);
    }

    public void WorkedOneDay()
    {
        if(!TimeManager.IsWeekend()) WorkedDays++;
    }

    public void Pay(ITaxPolicy taxPolicy)
    {
        double gross = (WorkedDays * (int)WorkHours * Salary) + (WorkedExtraHours * Salary * 1.5); 
        SalariesTotalBrut += gross;
        SalariesTotalNet += taxPolicy.CalculateNet(gross);
    }

    public double GetEmployeeMonthlySalary()
    {
        return (WorkedDays * (int)WorkHours * Salary) + (WorkedExtraHours * Salary * 1.5);
    }

    // Call this after loading employees from JSON
    public static void SetCounterFromExisting(List<Employee> employees)
    {
        if (employees.Count > 0)
            _idCounter = Math.Max(_idCounter, employees.Max(e => int.Parse(e.Id.Substring(3))));
    }
}