using Payroll.Logic;

namespace Payroll.Logic.UI;

public partial class PaymentHistory : UserControl
{
    private Employee _employee;
    private Dictionary<string, PayHistory> _payHistory;
    
    public PaymentHistory(Employee employee)
    {
        InitializeComponent();
        
        if (employee == null) return;
        
        _employee = employee;

        if (employee.PaymentHistory == null)
        {
            _payHistory = new Dictionary<string, PayHistory>();
        }
        else
        {
            _payHistory = employee.PaymentHistory;
        }

        LoadListView();
    }

    private void LoadListView()
    {
        listView1.Items.Clear();

        if (_payHistory == null) return;

        foreach (KeyValuePair<string, PayHistory> entry in _payHistory)
        {
            string dateKey = entry.Key;
            PayHistory data = entry.Value;

            ListViewItem item = new ListViewItem(dateKey);

            item.SubItems.Add(data.grossPay.ToString("C")); 
            item.SubItems.Add(data.netPay.ToString("C"));
            item.SubItems.Add(data.CAS.ToString("C"));
            item.SubItems.Add(data.CASS.ToString("C"));
            item.SubItems.Add(data.IncomeTax.ToString("C"));
            item.SubItems.Add(data.workedDays.ToString());
            
            listView1.Items.Add(item);
        }
    }
}