namespace Payroll.Logic;

public class PayHistory
{
    private decimal grossPay { get; }
    private decimal netPay { get; }
    private decimal CAS { get; }
    private decimal CASS { get; }
    private decimal IncomeTax { get; }
    private decimal SpecialTax { get; }
    private int workedDays { get; }
    private int OvertimeHours { get; }

    public PayHistory(decimal grossPay, decimal netPay, decimal cas, decimal cass, decimal incomeTax, decimal specialTax, int workedDays, int overtimeHours)
    {
        this.grossPay = grossPay;
        this.netPay = netPay;
        CAS = cas;
        CASS = cass;
        IncomeTax = incomeTax;
        SpecialTax = specialTax;
        this.workedDays = workedDays;
        OvertimeHours = overtimeHours;
    }
}