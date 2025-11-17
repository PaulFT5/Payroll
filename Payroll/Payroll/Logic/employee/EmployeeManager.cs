using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Payroll.Logic;

public static class EmployeeManager
{
    public static List<Employee> Employees { get; set; } = new List<Employee>();
    private static readonly string FilePath = Path.Combine("S:\\Cs\\FCPLproj\\Payroll\\Payroll\\Logic\\employee.json");

    public static void SaveEmployees()
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        
            string json = JsonSerializer.Serialize(Employees, options);
            Console.WriteLine($"[DEBUG] Serialized JSON: {json.Substring(0, Math.Min(200, json.Length))}...");
            File.WriteAllText(FilePath, json);
            Console.WriteLine($"[DEBUG] Employees saved to {FilePath}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving employees: {ex.Message}");
        }
    }

    public static void LoadEmployees()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                Employees = new List<Employee>();
                return;
            }

            string json = File.ReadAllText(FilePath);
            
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new JsonStringEnumConverter() }
            };
            
            var loaded = JsonSerializer.Deserialize<List<Employee>>(json, options);
            
            if (loaded != null)
            {
                Employees.Clear();
                Employees.AddRange(loaded);
            }

            // Restore the static ID counter correctly
            Employee.SetCounterFromExisting(Employees);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading employees: {ex.Message}");
            Employees.Clear();
        }
    }
}