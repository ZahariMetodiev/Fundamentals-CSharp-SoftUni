using System;

namespace T04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNumbers(i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintNumbers(i);
            }
        }

        static void PrintNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
