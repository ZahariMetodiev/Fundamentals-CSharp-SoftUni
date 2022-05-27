using System;
using System.Text;

namespace T04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var symbol in text)
            {
                int replaceSymbol = symbol + 3;
                stringBuilder.Append(Convert.ToChar(replaceSymbol));
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
