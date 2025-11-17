namespace Payroll.Logic.UI;

public partial class AddEmployee : UserControl
{
    public AddEmployee()
    {
        InitializeComponent();
        workHoursComboBox.DataSource = Enum.GetValues(typeof(workHoursEnum));
        ContractTypeComboBox.DataSource = Enum.GetValues(typeof(contractTypeEnum));
        workHoursComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ContractTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private int money;
    private workHoursEnum workHours;
    private contractTypeEnum contractType;

    private void salary_ValueChanged(object sender, EventArgs e)
    {
        money = (int)salary.Value;
    }

    private void workHoursComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        workHours = (workHoursEnum)(workHoursComboBox.SelectedItem ?? throw new InvalidOperationException());
    }

    private void ContractTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        contractType = (contractTypeEnum)(ContractTypeComboBox.SelectedItem ?? throw new InvalidOperationException());
    }

    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        var emp = new Employee(money, workHours, contractType);
        EmployeeManager.Employees.Add(emp);
        EmployeeManager.SaveEmployees();

        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}