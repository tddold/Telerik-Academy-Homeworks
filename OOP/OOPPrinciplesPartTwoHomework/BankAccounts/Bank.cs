namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private IList<Deposite> depositeAccounts;
        private IList<Loan> loanAccounts;
        private IList<Mortgage> mortgageAccounts;

        public Bank()
        {
            this.depositeAccounts = new List<Deposite>();
            this.loanAccounts = new List<Loan>();
            this.mortgageAccounts = new List<Mortgage>();
        }

        public string DepositeAccounts
        {
            get
            {
                StringBuilder depositeAccountsToString = new StringBuilder();

                foreach (var account in this.depositeAccounts)
                {
                    string currentAccount = string.Format(
                        "Type of customer: {0, -11} | Balance: {1, -19:C} | Interest rate: {2,-5} %", 
                         account.Customer,
                         account.Balance,
                         account.InterestRate);

                    depositeAccountsToString.Append(currentAccount + Environment.NewLine);
                }

                return depositeAccountsToString.ToString();
            }
        }

        public string LoanAccounts
        {
            get
            {
                StringBuilder loanAccountsToString = new StringBuilder();

                foreach (var account in this.loanAccounts)
                {
                    string currentAccount = string.Format(
                        "Type of customer: {0, -11} | Balance: {1, -19:C} | Interest rate: {2,-5} %",
                        account.Customer,
                        account.Balance,
                        account.InterestRate);

                    loanAccountsToString.Append(currentAccount + Environment.NewLine);
                }

                return loanAccountsToString.ToString();
            }
        }

        public string MortgageAccounts
        {
            get
            {
                StringBuilder mortgageAccountsToString = new StringBuilder();

                foreach (var account in this.mortgageAccounts)
                {
                    string currentAccount = string.Format(
                        "Type of customer: {0, -11} | Balance: {1, -19:C} | Interest rate: {2,-5} %",
                        account.Customer,
                        account.Balance,
                        account.InterestRate);

                    mortgageAccountsToString.Append(currentAccount + Environment.NewLine);
                }

                return mortgageAccountsToString.ToString();
            }
        }

        public void AddDepositeAccount(params Deposite[] accounts)
        {
            foreach (var account in accounts)
            {
                this.depositeAccounts.Add(account);
            }
        }

        public void AddLoanAccount(params Loan[] accounts)
        {
            foreach (var account in accounts)
            {
                this.loanAccounts.Add(account);
            }
        }

        public void AddMortgageAccount(params Mortgage[] accounts)
        {
            foreach (var account in accounts)
            {
                this.mortgageAccounts.Add(account);
            }
        }
    }
}
