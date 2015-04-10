namespace BankAccounts
{
    using System;

    public class Deposite : Account, IDepositeMoney, IWithDrawMoney
    {
        private const decimal LackOfInterestAmount = 0.0m;

        public Deposite(Customers currentCustomer, decimal currentBalance, decimal currentInterestRate)
            : base(currentCustomer, currentBalance, currentInterestRate)
        {
        }
        
        public void DepositeMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithDrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new InvalidOperationException("You don't have enough money in you balance");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException();
            }

            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return LackOfInterestAmount;
            }
            else
            {
                return months * this.Interest;
            }
        }
    }
}
