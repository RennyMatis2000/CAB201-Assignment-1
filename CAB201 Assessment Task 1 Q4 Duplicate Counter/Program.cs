using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Q4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide a list of integers in a single line, separated by _:");
            string integerList = Console.ReadLine();
            integerList = integerList.Trim();
            string[] splitIntegerList = integerList.Split("_");
            int duplicateCounter = 0;

            List<int> duplicates = new List<int>();

            for (int i = 0; i < splitIntegerList.Length; i++) 
            {

                if (!string.IsNullOrWhiteSpace(splitIntegerList[i]))
                {
                    string trimmedIntegerList = splitIntegerList[i].Trim();

                    if(int.TryParse(trimmedIntegerList, out int guaranteedInteger))
                    {
                        duplicates.Add(guaranteedInteger);
                    }
                }
            }

            duplicates.Sort();

            for (int i = 0; i < duplicates.Count - 1; i++)
            {
                if (duplicates[i] == duplicates[i + 1])
                {
                    duplicateCounter++;

                    while (i < duplicates.Count - 1 && duplicates[i] == duplicates[i + 1])
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine($"The total number of values with repeats is {duplicateCounter}.");

           
            
            


        }
    }
}