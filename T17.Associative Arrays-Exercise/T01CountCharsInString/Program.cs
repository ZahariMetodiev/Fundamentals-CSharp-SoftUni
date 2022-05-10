using System;
using System.Collections.Generic;
using System.Linq;

namespace T01CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var symbol in word)
                {
                    if (counts.ContainsKey(symbol))
                    {
                        counts[symbol]++;
                    }
                    else
                    {
                        counts.Add(symbol, 1);
                    }
                }
            }

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
