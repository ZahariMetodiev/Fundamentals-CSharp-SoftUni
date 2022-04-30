using System;

namespace T02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = VowelsCount(input);
            Console.WriteLine(result);
        }

        static int VowelsCount(string text)
        {
            int vowelsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                
                if (currentSymbol == 'a' || currentSymbol == 'e' || currentSymbol == 'i'
                    || currentSymbol == 'o' || currentSymbol == 'u' || currentSymbol == 'y')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
