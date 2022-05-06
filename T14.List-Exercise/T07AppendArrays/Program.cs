using System;
using System.Collections.Generic;
using System.Linq;

namespace T07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> currentList = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < currentList.Count; j++)
                {
                    Console.Write($"{currentList[j]} ");
                }

            }
        }
    }
}
