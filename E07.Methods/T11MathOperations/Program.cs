using System;

namespace T11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int fyrstNumber = int.Parse(Console.ReadLine());
            string operatoR = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(fyrstNumber, operatoR, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(int a, string operatoR, int b)
        {
            double result = 0;

            if (operatoR == "*")
            {
                result = a * b;
            }
            else if (operatoR == "+")
            {
                result = a + b;
            }
            else if (operatoR == "-")
            {
                result = a - b;
            }
            else if (operatoR == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}
