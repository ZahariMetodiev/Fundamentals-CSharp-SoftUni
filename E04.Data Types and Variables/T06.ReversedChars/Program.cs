using System;

namespace T06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.Write($"{thirdChar} {secondChar} {firstChar}");

        }
    }
}
