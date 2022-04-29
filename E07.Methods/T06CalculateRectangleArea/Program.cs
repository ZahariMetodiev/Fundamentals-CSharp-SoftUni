using System;

namespace T06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = CalculateRectangleArea(widht, height);
            Console.WriteLine(result);
        }

        static double CalculateRectangleArea(double widht , double height)
        {
            return widht * height;
        }
    }
}
