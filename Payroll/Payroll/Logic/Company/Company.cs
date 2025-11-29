using System;

namespace Payroll.Logic
{ //
    public class Company : ICompany
    {
        private int _money;

        public Company(int startingMoney)
        {
            _money = startingMoney;
        }

        public void RecieveMonthlyMoney()
        {
            var random = new Random();
            int income = random.Next(15730, 32250);
            _money += income;
        }
        
        public void Withdraw(int amount)
        {
            if (amount > _money)
                throw new InvalidOperationException("Not enough company money!");

            _money -= amount;
        }

        public int MoneyInCompany => _money;
    }
}