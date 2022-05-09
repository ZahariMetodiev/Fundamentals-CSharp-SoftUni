using System;
using System.Collections.Generic;

namespace T03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!(words.ContainsKey(word)))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonyms);
                }
                else
                {
                    words[word].Add(synonyms);
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
