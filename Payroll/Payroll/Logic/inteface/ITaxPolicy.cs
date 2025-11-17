namespace Payroll.Logic;

public interface ITaxPolicy
{
    double CalculateNet(double gross);
}