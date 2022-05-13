using System;
using System.Text;

namespace T06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            char prevLetter = '\0';

            foreach (var letter in text)
            {
                if (letter != prevLetter)
                {
                    result.Append(letter);
                }
                prevLetter = letter;
            }

            Console.WriteLine(result);
        }
    }
}
