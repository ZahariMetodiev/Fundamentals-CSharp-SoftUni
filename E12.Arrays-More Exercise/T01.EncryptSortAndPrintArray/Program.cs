using System;
using System.Linq;

namespace T01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char currentSymbol = input[j];

                    if (currentSymbol == 'a' || currentSymbol == 'A'||
                        currentSymbol == 'o' || currentSymbol == 'O'||
                        currentSymbol == 'e' || currentSymbol == 'E'||
                        currentSymbol == 'i' || currentSymbol == 'I'||
                        currentSymbol == 'u' || currentSymbol == 'U')
                    {
                        sum += currentSymbol * input.Length;
                    }
                    else
                    {
                        sum += currentSymbol / input.Length;
                    }
                }
                    output[i] = sum;
            }
            Array.Sort(output);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
