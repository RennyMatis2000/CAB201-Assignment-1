using System;
using System.ComponentModel.Design;

namespace Q3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Insert your solution here.
            Console.WriteLine("Enter the simulation period (whole years):");
            string yearsString = Console.ReadLine();
            int years = Convert.ToInt32(yearsString);

            if (years >= 1)
            {
                Console.WriteLine("Enter the number of towns:");
                string numberTownsString = Console.ReadLine();
                int numberTowns = Convert.ToInt32(numberTownsString);

                if (numberTowns >= 1)
                {
                    for (int i = 0; i < numberTowns; i++)
                    {
                        Console.WriteLine("Enter the name of the town:");
                        string townName = Console.ReadLine();

                        Console.WriteLine("Enter the initial population of the town:");
                        string initialTownPopulationString = Console.ReadLine();
                        int initialTownPopulation = Convert.ToInt32(initialTownPopulationString);

                        Console.WriteLine("Enter the growth rate of the town:");
                        string growthRateString = Console.ReadLine();
                        double growthRate = Convert.ToDouble(growthRateString);

                        double finalTownPopulation = initialTownPopulation;

                        for (int i2 = 0; i2 < years; i2++)
                        {
                            finalTownPopulation *= growthRate;
                            finalTownPopulation = Math.Round(finalTownPopulation);
                        }

                        Console.WriteLine($"The population of {townName} goes from {initialTownPopulation} to {finalTownPopulation} with growth factor {growthRate} after {years} years.");
                    }
                }
                else
                {
                    Console.WriteLine("Simulation cancelled: no towns.");
                }
            }
            else
            {
                Console.WriteLine("Simulation cancelled: no years.");
            }
        }
    }
}
