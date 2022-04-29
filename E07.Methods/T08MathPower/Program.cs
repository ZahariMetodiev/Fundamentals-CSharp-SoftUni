using System;

namespace T08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(number, power);
            Console.WriteLine(result);
        }

        static double MathPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
