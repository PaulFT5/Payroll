namespace Payroll.Logic;

public interface ITaxPolicy
{
    double CalculateNet(Employee employee, double gross);
}