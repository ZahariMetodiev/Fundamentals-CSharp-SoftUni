using System;

namespace T08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = CalculateFactorial(num1) / CalculateFactorial(num2);
            Console.WriteLine($"{result:f2}");
        }

        static decimal CalculateFactorial(int number)
        {
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
