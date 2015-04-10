/*
Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account 
using the appropriate data types and descriptive names.
*/

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Georgiev";
        object holderName = firstName + " " + middleName + " " + lastName; 
        decimal balance = 45800.74m;
        string bankName = "JP Morgan Chase & Co.";
        string internationalBankAccountNumber = "GB 29CH AS60 9242 3619 1201";
        ulong creditCardNumberOne = 3566002020360505u;
        ulong creditCardNumberTwo = 3530111333300000u;
        ulong creditCardNumberThree = 6011000990139424u;

        Console.WriteLine("Holder name: {0}", holderName);
        Console.WriteLine("Balance: {0:c}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", internationalBankAccountNumber);
        Console.WriteLine("Credit card № 1: {0:#### #### #### ####}", creditCardNumberOne);
        Console.WriteLine("Credit card № 2: {0:#### #### #### ####}", creditCardNumberTwo);
        Console.WriteLine("Credit card № 3: {0:#### #### #### ####}", creditCardNumberThree);
    }
}

