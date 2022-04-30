using System;

namespace T01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fyrstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = FindSmallestOfThreeNumbers(fyrstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        static int FindSmallestOfThreeNumbers(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
