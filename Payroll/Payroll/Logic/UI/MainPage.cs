using Payroll.Logic;
using Payroll.Logic.UI;

namespace Payroll.UI;

public partial class MainPage : Form
{
    private PayrollService _payrollService;
    private Company _company;

    public MainPage()
    {
        InitializeComponent();
       
        labelMockDate.Text = $"Date: {TimeManager.MockDate:MMM dd, yyyy}";
        // Subscribe to global date updates
        TimeManager.OnDateChanged += UpdateDateLabel;
        EmployeeManager.LoadEmployees(); // Load employees from JSON
        Employee.SetCounterFromExisting(EmployeeManager.Employees); // Sync ID counter

        _company = new Company(15000);
        _payrollService = new PayrollService(new TaxPolicy(), _company ,payday: 7);
    }
    
    private void UpdateDateLabel(DateTime newDate)
    {
        labelMockDate.Text = $"Date: {newDate:MMM dd, yyyy}";
    }

    private void button5_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Add_Click(object sender, EventArgs e)
    {
        ShowPage(new AddEmployee());
    }

    private void manage_Click(object sender, EventArgs e)
    {
        //ShowPage(new ManageEmployee());
        throw new  NotImplementedException();
    }

    private void timer_Click(object sender, EventArgs e)
    {
        TimeManager.Toggle();
        timer.Text = TimeManager.IsRunning ? "Pause Timer" : "Start Timer";
    }

    private void stats_Click(object sender, EventArgs e)
    {
        //ShowPage(new Stats());
        throw new NotImplementedException();
    }

    private void exit_Click(object sender, EventArgs e)
    {
        EmployeeManager.SaveEmployees();
        Application.Exit();
    }
    
    private void ShowPage(UserControl page)
    {
        AppPanel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        AppPanel.Controls.Add(page);
    }
}
