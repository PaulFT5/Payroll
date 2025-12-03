namespace Payroll.Logic.UI
{
    public partial class ManageEmployee : UserControl
    {
        public ManageEmployee()
        {
            InitializeComponent();
            EmployeeManager.LoadEmployees();
            LoadListView();
        }

        private void LoadListView()
        {
            listView1.Items.Clear();

            foreach (var emp in EmployeeManager.Employees)
            {
                ListViewItem item = new ListViewItem(emp.Id);
                item.SubItems.Add(emp.ContractType.ToString());
                item.SubItems.Add(emp.WorkHours.ToString());
                item.SubItems.Add(emp.ExpectedSalary.ToString());
                item.SubItems.Add(emp.Salary.ToString());

                listView1.Items.Add(item);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an employee to remove.");
                return;
            }

            string selectedId = listView1.SelectedItems[0].Text;
            
            var emp = EmployeeManager.Employees
                .FirstOrDefault(e => e.Id == selectedId);

            if (emp != null)
            {
                EmployeeManager.Employees.Remove(emp);
                EmployeeManager.SaveEmployees();
            }

            LoadListView(); 
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
    }
}