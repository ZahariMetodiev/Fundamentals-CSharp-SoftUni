using System;
using System.Collections.Generic;
using System.Linq;

namespace T03MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split().ToArray();

                if (commands[0] == "Shoot")
                {
                    int index = int.Parse(commands[1]);
                    int power = int.Parse(commands[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        if (targets[index] > power)
                        {
                            targets[index] -= power;
                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commands[0] == "Add")
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (commands[0] == "Strike")
                {
                    int index = int.Parse(commands[1]);
                    int radius = int.Parse(commands[2]);

                    if (index - radius >= 0 && index + radius < targets.Count)
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
