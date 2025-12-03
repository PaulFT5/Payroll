using System.Globalization;

namespace Payroll.Logic.UI;

public partial class MonthlyStats : UserControl
{
    public MonthlyStats(Employee employee)
    {
        InitializeComponent();

        label11.Text = employee.ExpectedSalary.ToString();
        label12.Text = employee.CAS.ToString(CultureInfo.InvariantCulture);
        label13.Text = employee.CASS.ToString(CultureInfo.InvariantCulture);
        label14.Text = employee.IncomeTax.ToString(CultureInfo.InvariantCulture);
        label15.Text = employee.SpecialTax.ToString(CultureInfo.InvariantCulture);
        label16.Text = employee.gross.ToString();
        label17.Text = employee.WorkedDays.ToString();
        label18.Text = employee.WorkedExtraHours.ToString();
        label19.Text = employee.WorkedExtraPay.ToString();
        label20.Text = employee.MissedDays.ToString();
    }
    
}