using System;
using System.Collections.Generic;
using System.Linq;

namespace T02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWord = word.ToLower();

                if (counts.ContainsKey(currentWord))
                {
                    counts[currentWord]++;
                }
                else
                {
                    counts.Add(currentWord, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
