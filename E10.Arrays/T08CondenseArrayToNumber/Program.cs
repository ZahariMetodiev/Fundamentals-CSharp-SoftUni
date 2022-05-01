using System;
using System.Linq;

namespace T08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                sum += numbers[i] + numbers[i + 1];
            }

            Console.WriteLine(sum);
        }
    }
}
