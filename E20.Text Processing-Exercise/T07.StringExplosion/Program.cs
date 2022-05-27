using System;
using System.Text;

namespace T07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (currentSymbol == '>')
                {
                    bomb += text[i + 1] - '0';
                    result.Append(currentSymbol);
                }
                else if (bomb > 0)
                {
                    bomb--;
                }
                else
                {
                    result.Append(currentSymbol);
                }
            }

            Console.WriteLine(result);
        }
    }
}
