using System;

namespace T07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n);
        }

        static void PrintNumbers(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
