using System;
using System.Linq;

namespace T04ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(' ', input.Reverse()));
        }
    }
}
