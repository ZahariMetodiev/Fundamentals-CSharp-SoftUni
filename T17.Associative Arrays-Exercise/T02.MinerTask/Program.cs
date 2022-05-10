using System;
using System.Collections.Generic;

namespace T02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourseInformation = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourseInformation.ContainsKey(input))
                {
                    resourseInformation[input] += quantity;
                }
                else
                {
                    resourseInformation.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var resourse in resourseInformation)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
