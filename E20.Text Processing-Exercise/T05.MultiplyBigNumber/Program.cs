using System;

namespace T05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal firstNumber = ulong.Parse(Console.ReadLine());
            Decimal secondNumber = ulong.Parse(Console.ReadLine());

            Decimal result = firstNumber * secondNumber;

            Console.WriteLine(result);
        }
    }
}
