namespace BankAccounts
{
    using System;

    public abstract class Account : ICalculateInterest
    {
        protected readonly decimal Interest;
        private decimal balance;
        private decimal interestRate;

        public Account(Customers currentCustomer, decimal currentBalance, decimal currentInterestRate)
        {
            this.Customer = currentCustomer;
            this.Balance = currentBalance;
            this.InterestRate = currentInterestRate;
            this.Interest = currentInterestRate;
        }

        public Customers Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException();
            }

            return months * this.Interest;
        }
    }
}
