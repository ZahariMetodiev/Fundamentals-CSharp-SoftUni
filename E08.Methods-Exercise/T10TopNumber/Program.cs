using System;

namespace T10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsDigitSumDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDigitSumDivisibleBy8(int number)
        {
            int digitSum = 0;

            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 != 0 )
                {
                    return true;
                }

                number /= 10;
            }
            return false;
        }
    }
}
