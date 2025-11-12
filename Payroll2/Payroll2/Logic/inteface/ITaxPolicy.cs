namespace Payroll2.Logic;

public interface ITaxPolicy
{
    double CalculateNet(double gross);
}