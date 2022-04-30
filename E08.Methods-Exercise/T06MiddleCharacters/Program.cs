using System;

namespace T06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = GetMiddleCharacters(input);
            Console.WriteLine(result);
        }

        static string GetMiddleCharacters(string text)
        {
            string result = "";

            if (text.Length % 2 == 0)
            {
                result = text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
            }
            else
            {
                result = text[text.Length / 2].ToString();
            }

            return result;
        }
    }
}
