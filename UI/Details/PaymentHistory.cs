namespace Payroll.Logic.UI;

public partial class PaymentHistory : UserControl
{
    public PaymentHistory()
    {
        InitializeComponent();
        var emp = EmployeeManager.Employees;
    }
}