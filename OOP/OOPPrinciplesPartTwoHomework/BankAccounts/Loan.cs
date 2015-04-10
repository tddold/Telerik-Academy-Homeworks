namespace BankAccounts
{
    using System;

    public class Loan : Account, IDepositeMoney
    {
        private const decimal LackOfInterestAmount = 0.0m;
        private const int CompanyHolderNumberOfMonths = 2;
        private const int IndividualHolderNumberOfMonths = 3;

        public Loan(Customers currentCustomer, decimal currentBalance, decimal currentInterestRate)
            : base(currentCustomer, currentBalance, currentInterestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException();
            }

            if (this.Customer == Customers.Companies)
            {
                if (months <= CompanyHolderNumberOfMonths)
                {
                    return LackOfInterestAmount;
                }
                else
                {
                    return (months - CompanyHolderNumberOfMonths) * this.Interest;
                }
            }
            else
            {
                if (months <= IndividualHolderNumberOfMonths)
                {
                    return LackOfInterestAmount;
                }
                else
                {
                    return (months - IndividualHolderNumberOfMonths) * this.Interest;
                }
            }
        }

        public void DepositeMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
