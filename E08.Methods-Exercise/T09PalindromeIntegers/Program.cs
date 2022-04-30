using System;
using System.Linq;

namespace T09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());

                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string text)
        {
            char[] reversed = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!(reversed[i] == text[i]))
                {
                    return false;
                }
            }
            return true;

            
        }
    }
}
