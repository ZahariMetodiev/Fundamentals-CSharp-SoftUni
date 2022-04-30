using System;

namespace T05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = CalculateNumbers(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        static int CalculateNumbers(int first, int second, int thirt)
        {
            return (first + second) - thirt;
        }

    }
}
