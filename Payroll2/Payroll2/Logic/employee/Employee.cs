using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Payroll2.Logic;

public class Employee
{
    private static int _idCounter = 0;
    
    public string Id { get; set; }
    public int Salary { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public workHoursEnum WorkHours { get; set; }
    
    public int ExpectedSalary { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public contractTypeEnum ContractType { get; set; }
    
    public int WorkedDays { get; set; }
    public double SalariesTotalBrut { get; set; }
    public double SalariesTotalNet { get; set; }
    public DateTime HiringDate { get; set; }
    public List<bool> Paid { get; set; } 

    public Employee() { } // parameterless constructor for JSON

    public Employee(int salary, workHoursEnum workHours, contractTypeEnum contractType)
    {
        Id = $"EMP{++_idCounter:D6}";
        Salary = salary;
        ExpectedSalary = 20 * (int)workHours * salary;
        WorkHours = workHours;
        ContractType = contractType;
        WorkedDays = 0;
        SalariesTotalBrut = 0;
        SalariesTotalNet = 0;
        HiringDate = TimeManager.MockDate;
        Paid = new List<bool>(new bool[12]);
    }

    public void WorkedOneDay() => WorkedDays++;

    public void Pay(ITaxPolicy taxPolicy)
    {
        double gross = WorkedDays * (int)WorkHours * Salary; 
        SalariesTotalBrut += gross;
        SalariesTotalNet += taxPolicy.CalculateNet(gross);
    }

    // Call this after loading employees from JSON
    public static void SetCounterFromExisting(List<Employee> employees)
    {
        if (employees.Count > 0)
            _idCounter = Math.Max(_idCounter, employees.Max(e => int.Parse(e.Id.Substring(3))));
    }
}