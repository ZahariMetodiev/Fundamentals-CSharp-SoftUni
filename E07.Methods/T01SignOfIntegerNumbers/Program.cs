using System;

namespace T01SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(SignOfIntegerNumbers(num));
        }

        static string SignOfIntegerNumbers(int number)
        {
            string sign = "";
            
            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else if (number == 0)
            {
                sign = "zero";
            }

            return $"The number {number} is {sign}.";
        }
    }
}
