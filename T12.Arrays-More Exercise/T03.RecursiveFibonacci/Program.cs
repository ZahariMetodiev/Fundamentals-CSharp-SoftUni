using System;

namespace T03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonachiRecursion(n));
        }

        static long FibonachiRecursion(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }
    }
}