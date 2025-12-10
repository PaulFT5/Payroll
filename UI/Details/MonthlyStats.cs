using System.Globalization;
using Payroll.Logic; // Needed to use TaxPolicy

namespace Payroll.Logic.UI;

public partial class MonthlyStats : UserControl
{
    public MonthlyStats(Employee employee)
    {
        InitializeComponent();
        
        double currentGross = employee.GetEmployeeMonthlySalary();
        
        TaxPolicy policy = new TaxPolicy();
        policy.CalculateNet(employee, currentGross);
        
        label11.Text = employee.ExpectedSalary.ToString();
        label12.Text = employee.CAS.ToString("F2", CultureInfo.InvariantCulture);
        label13.Text = employee.CASS.ToString("F2", CultureInfo.InvariantCulture);
        label14.Text = employee.IncomeTax.ToString("F2", CultureInfo.InvariantCulture);
        label15.Text = employee.SpecialTax.ToString("F2", CultureInfo.InvariantCulture);
        
        label16.Text = currentGross.ToString("F2", CultureInfo.InvariantCulture);
        
        label17.Text = employee.WorkedDays.ToString();
        label18.Text = employee.WorkedExtraHours.ToString();
        label19.Text = employee.WorkedExtraPay.ToString("F2", CultureInfo.InvariantCulture);
        label20.Text = employee.MissedDays.ToString();
    }
}