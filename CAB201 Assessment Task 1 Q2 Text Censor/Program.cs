using System;
using System.Text;

namespace Q2
{
    public class Q2
    {
        static void Main(string[] args)
        {
            // Insert your solution here.
            Console.WriteLine("Enter the text to be censored:");

            string enteredText = Console.ReadLine();

            Console.WriteLine("Enter the number of phrases to censor:");

            string numberPhrasesString = Console.ReadLine();
            int numberPhrases = Convert.ToInt32(numberPhrasesString);
            string censoredText = enteredText;

            for (int i = 0; i < numberPhrases; i++)
            {
                Console.WriteLine("Phrase:");
                string phrases = Console.ReadLine();
                int phraseLength = phrases.Length;
                string censor = new string('*', phraseLength);
                censoredText = censoredText.Replace(phrases, censor);
            }
            Console.WriteLine($"The censored text is as follows: {censoredText}");
        }
    }
}