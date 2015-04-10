namespace BankAccounts
{
    using System;

    // Problem 2. Bank accounts

    // A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
    // Customers could be individuals or companies.

    // All accounts have customer, balance and interest rate (monthly based).
    // Deposit accounts are allowed to deposit and with draw money.
    // Loan and mortgage accounts can only deposit money.

    // All accounts can calculate their interest amount for a given period (in months). 
    // In the common case its is calculated as follows: number_of_months * interest_rate.

    // Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.

    // Deposit accounts have no interest if their balance is positive and less than 1000.

    // Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

    // Your task is to write a program to model the bank system by classes and interfaces.

    // You should identify the classes, interfaces, base classes and abstract actions and implement 
    // the calculation of the interest functionality through overridden methods.
    public class Test
    {
        public static void Main()
        {
            // Some accounts
            Deposite firstDeposite = new Deposite(Customers.Companies, 100000, 1.4m);
            Deposite secondDeposite = new Deposite(Customers.Individuals, 2500, 3.4m);

            Loan firstLoan = new Loan(Customers.Companies, 2400000m, 2.7m);
            Loan secondLoan = new Loan(Customers.Individuals, 7500, 1.001m);

            Mortgage firstMortgage = new Mortgage(Customers.Companies, 12400m, 5.1m);
            Mortgage secondMortgage = new Mortgage(Customers.Individuals, 4500, 0.11m);

            // Add and with draw some money
            firstDeposite.WithDrawMoney(1000.0m);
            secondDeposite.DepositeMoney(1000.0m);
            secondLoan.DepositeMoney(100);
            firstMortgage.DepositeMoney(600);

            // Calculate interests of amount
            decimal firstAmount = firstDeposite.CalculateInterestAmount(12); 
            Console.WriteLine("Interest amount {0:F3} %", firstAmount);

            decimal secondAmount = firstMortgage.CalculateInterestAmount(7);
            Console.WriteLine("Interest amount {0:F3} %\n", secondAmount);

            // Create a bank
            Bank bank = new Bank();

            // Adding some accounts in the bank
            bank.AddDepositeAccount(firstDeposite, secondDeposite);
            bank.AddLoanAccount(firstLoan, secondLoan);
            bank.AddMortgageAccount(firstMortgage, secondMortgage);

            // Print information about all account in the bank
            Console.WriteLine(bank.DepositeAccounts);
            Console.WriteLine(bank.LoanAccounts);
            Console.WriteLine(bank.MortgageAccounts);
        }
    }
}
