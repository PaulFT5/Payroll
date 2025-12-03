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
                item.SubItems.Add(emp.name);
                item.SubItems.Add(emp.surname);
                item.SubItems.Add(emp.WorkHours.ToString());
                item.SubItems.Add(emp.ContractType.ToString());

                listView1.Items.Add(item);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an employee to show details.");
                return;
            }

            string selectedId = listView1.SelectedItems[0].Text;
            
            var emp = EmployeeManager.Employees
                .FirstOrDefault(e => e.Id == selectedId);
            
            if (emp != null)
            {
              //  EmployeeManager.Employees.Remove(emp);
              //  EmployeeManager.SaveEmployees();
              var empDetails = new EmployeeDetails(emp);
              
              DialogResult result = empDetails.ShowDialog();
              
              if (result == DialogResult.OK) 
              {
                  LoadListView(); 
              }
            }
            
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
    }
}