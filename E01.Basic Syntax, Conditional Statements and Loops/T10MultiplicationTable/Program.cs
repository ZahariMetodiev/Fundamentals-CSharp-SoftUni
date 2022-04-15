using System;

namespace T10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numbers} X {i} = {numbers * i}");
            }
        }
    }
}
