using System;

namespace T09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numbers * 2; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
