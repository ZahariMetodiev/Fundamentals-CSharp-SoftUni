using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Calculations(command, firstNum, secondNum);
        }

        static void Calculations(string command, int first, int second)
        {
            switch (command)
            {
                case "add":
                    Console.WriteLine(first + second);
                    break;
                case "subtract":
                    Console.WriteLine(first - second);
                    break;
                case "multiply":
                    Console.WriteLine(first * second);
                    break;
                case "divide":
                    Console.WriteLine(first / second);
                    break;
            }
        }
    }
}