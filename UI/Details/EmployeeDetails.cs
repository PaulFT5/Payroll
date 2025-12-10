using System.Reflection.Metadata.Ecma335;

namespace Payroll.Logic.UI;

public partial class EmployeeDetails : Form
{
    private Employee emp;
    public EmployeeDetails(Employee employee) //passed as argument
    {
        InitializeComponent();
        this.emp = employee;
        label1.Text = $"ID: {emp.Id}, Name: {emp.name} {emp.surname}";
        ShowPage(new  MonthlyStats(emp));
    }
    
    private void ShowPage(UserControl page)
    {
        panel2.Controls.Clear();
        page.Dock = DockStyle.Fill;
        panel2.Controls.Add(page);
    }


    private void fireButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show($"Are you sure you want to fire employee with ID: {emp.Id}, Name: {emp.name} {emp.surname}", "Removing employee", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            EmployeeManager.Employees.Remove(emp);
            EmployeeManager.SaveEmployees();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        
    }

    private void statsButton_Click(object sender, EventArgs e)
    {
        ShowPage(new MonthlyStats(emp));
    }

    private void button_Click(object sender, EventArgs e)
    {
        ShowPage(new PaymentHistory());
    }
}