namespace BankAccounts
{
    using System;

    public class Mortgage : Account, IDepositeMoney
    {
        private const int CompanyHolderNumberOfMonths = 12;
        private const int IndividualHolderNumberOfMonths = 6;
        private const decimal LackOfInterestAmount = 0.0m;

        public Mortgage(Customers currentCustomer, decimal currentBalance, decimal currentInterestRate)
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
                    return (this.Interest / 2) * months;
                }
                else
                {
                    decimal amountPartOne = (this.Interest / 2) * CompanyHolderNumberOfMonths;
                    decimal amountPartTwo = this.Interest * (months - CompanyHolderNumberOfMonths);

                    return amountPartOne + amountPartTwo;
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
