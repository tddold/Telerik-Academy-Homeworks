/*
Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AgeAfterTenYears
{
        private static int CalculateAge(DateTime birthday, DateTime currentDate)
    {
        int currentAge;

        if (currentDate.Month < birthday.Month)
        {
            currentAge = currentDate.Year - birthday.Year - 1;
        }
        else if (currentDate.Month > birthday.Month)
        {
            currentAge = currentDate.Year - birthday.Year;
        }
        else
        {
            if (currentDate.Day < birthday.Day)
            {
                currentAge = currentDate.Year - birthday.Year - 1;
            }
            else
            {
                currentAge = currentDate.Year - birthday.Year;
            }
        }
        return currentAge;
    }
    static void Main()
    {
        Console.Write("Please enter your birthday (example: 24.08.1990): ");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());

        DateTime currentDate = DateTime.Today;
        int currentAge = CalculateAge(birthday, currentDate);

        Console.WriteLine("You are {0} years old. After 10 years you will be {1} years old.", currentAge, currentAge + 10);
    }
    
}

