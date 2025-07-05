using System;
using System.Xml.Schema;

namespace Q1
{
    public class Q1
    {
        static void Main(string[] args)
        {
            // Insert your solution here.

            // Insert the month
            Console.WriteLine("Enter the month:");
            string inputMonthString = Console.ReadLine();
            int inputMonth = Convert.ToInt32(inputMonthString);

            // Insert the day
            Console.WriteLine("Enter the day:");
            string inputDayString = Console.ReadLine();
            int inputDay = Convert.ToInt32(inputDayString);

            bool validityMonth = false;
            bool validityDay = false;
            string validity = "invalid";

            if (inputMonth >= 1 && inputMonth <= 12)
            {
                validityMonth = true;

            } 
            if (inputDay >= 1 && inputDay <= 31)
            {
                validityDay = true;
            }
            if (inputMonth == 2 && inputDay >= 29 && inputDay >= 1)
            {
                validityDay = false;
            }
            if (inputDay == 31 && (inputMonth == 4 || inputMonth == 6 || inputMonth == 9 || inputMonth == 11))
            {
                validityDay = false;
            }
                if (validityMonth && validityDay)
            {
                validity = "valid";
            }

            Console.WriteLine($"Combination ({inputMonth},{inputDay}) is {validity}.");

        }
    }
}