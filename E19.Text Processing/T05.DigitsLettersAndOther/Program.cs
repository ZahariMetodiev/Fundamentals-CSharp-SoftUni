using System;
using System.Linq;

namespace T05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digit = string.Empty;
            string letter = string.Empty;
            string other = string.Empty;

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digit += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letter += symbol;
                }
                else
                {
                    other += symbol;
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);
        }
    }
}
