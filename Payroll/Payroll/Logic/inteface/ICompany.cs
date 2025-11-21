namespace Payroll.Logic;

public interface ICompany
{
    public void RecieveMonthlyMoney();
    public void Withdraw(int TotalSalaries);
}