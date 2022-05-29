using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            int movesCounter = 0;

            while (input != "end")
            {
                int[] index = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = index[0];
                int secondIndex = index[1];
                movesCounter++;

                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0)
                {
                    string currentElement = $"-{movesCounter}a";
                    int oldCount = elements.Count;

                    for (int i = oldCount / 2; i < oldCount / 2 + 2; i++)
                    {
                        elements.Insert(i, currentElement);
                    }
                    
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                        if (firstIndex == 0)
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(secondIndex - 1);
                        }
                        else
                        {
                            elements.RemoveAt(secondIndex);
                            elements.RemoveAt(firstIndex - 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', elements));
        }
    }
}