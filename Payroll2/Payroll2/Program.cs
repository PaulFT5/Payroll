using Payroll2.Logic;
using Payroll2.UI;

namespace Payroll2;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        EmployeeManager.LoadEmployees(); // Load first
        ApplicationConfiguration.Initialize();
        Application.Run(new MainPage());
        
    }
}