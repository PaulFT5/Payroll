namespace Payroll.Logic.UI;

public partial class 
    
    AddEmployee : UserControl
{
    public AddEmployee()
    {
        InitializeComponent();
        workHoursComboBox.DataSource = Enum.GetValues(typeof(workHoursEnum));
        ContractTypeComboBox.DataSource = Enum.GetValues(typeof(contractTypeEnum));
        workHoursComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ContractTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    }
    
    
    private string name = string.Empty, surname = string.Empty;
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
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string[] fullName = textBox1.Text.Split(' ');
        if (fullName.Length > 0)
            name = fullName[0];

        if (fullName.Length > 1)
            surname = fullName[1];

    }

    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
        {
            MessageBox.Show("Please enter a name and/or surname", "Failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (money <= 0)
        {
            MessageBox.Show("Please enter a valid money", "Failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (workHours == workHoursEnum.select || contractType == contractTypeEnum.select)
        {
            MessageBox.Show("Please enter a valid operation", "Failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }


        var emp = new Employee(name, surname, money, workHours, contractType);
        EmployeeManager.Employees.Add(emp);
        EmployeeManager.SaveEmployees();

        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    


}