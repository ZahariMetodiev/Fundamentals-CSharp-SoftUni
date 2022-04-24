using System;

namespace T04PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int fyrstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = fyrstNumber; i <= secondNumber; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}
