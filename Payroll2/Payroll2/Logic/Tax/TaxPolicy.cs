namespace Payroll2.Logic;

public class TaxPolicy : ITaxPolicy
{
    public double CalculateNet(double gross)
    {
        return gross > 2000 ? gross * 0.5 : gross * 0.45;
    }
}