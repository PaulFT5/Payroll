namespace Payroll.Logic;

public class PayHistory
{
    public decimal grossPay { get; }
    public decimal netPay { get; }
    public decimal CAS { get; }
    public decimal CASS { get; }
    public decimal IncomeTax { get; }
    public decimal SpecialTax { get; }
    public int workedDays { get; }
    public int OvertimeHours { get; }

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