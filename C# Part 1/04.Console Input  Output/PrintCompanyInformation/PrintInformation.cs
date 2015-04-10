/*
Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;

class PrintInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        ulong phoneNumber;
        bool parseSuccessPhoneNumber = true;

        do
        {
            Console.Write("Enter phone number: ");
            string value = Console.ReadLine();
            parseSuccessPhoneNumber = ulong.TryParse(value, out phoneNumber);
        }
        while (parseSuccessPhoneNumber == false || phoneNumber <= 0);

        
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();

        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }

        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        int age;
        bool parseSuccessAge = true;

        do
        {
            Console.Write("Enter manager age: ");
            string value = Console.ReadLine();
            parseSuccessAge = Int32.TryParse(value, out age);
        }
        while (parseSuccessAge == false || age <= 0);

        ulong managerPhoneNumber;
        bool parseSuccessManagerPhoneNumber = true;

        do
        {
            Console.Write("Enter manager phone number: ");
            string value = Console.ReadLine();
            parseSuccessManagerPhoneNumber = ulong.TryParse(value, out managerPhoneNumber);
        }
        while (parseSuccessManagerPhoneNumber == false || managerPhoneNumber < 0);

        Console.WriteLine();

        Console.WriteLine("{0}\nAdrress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. +{8:### # ### ###})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, age, managerPhoneNumber);
        
    }
}

