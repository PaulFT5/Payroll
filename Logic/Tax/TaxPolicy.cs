namespace Payroll.Logic;


public class TaxPolicy : ITaxPolicy
{
    public double CalculateNet(Employee employee, double gross)
    {
        employee.CAS = gross * 0.25;
        employee.CASS = gross * 0.10;
        employee.IncomeTax = gross * 0.10;

        if (employee.ExpectedSalary > 2000)
        {
            employee.SpecialTax = gross * 0.05;
        }
        else
        {
            employee.SpecialTax = 0;
        }
            

        double totalTaxes = employee.CAS + employee.CASS + employee.IncomeTax + employee.SpecialTax;

        return gross - totalTaxes; 
    }
}