using System;

namespace T10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(input);

            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;

            while (input != 0)
            {
                int currentNum = input % 10;

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                input /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;

            while (input != 0)
            {
                int currentNum = input % 10;

                if (currentNum % 2 != 0)
                {
                    oddSum += currentNum;
                }
                input /= 10;
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int result = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);

            return result;
        }

    }
}
