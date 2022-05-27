using System;
using System.Linq;

namespace T02ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            int shotCounter = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index < 0 || index > targets.Length - 1)
                {
                    continue;
                }
                else
                {
                    shotCounter++;
                    int currentNumber = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1 && targets[i] > currentNumber)
                        {
                            targets[i] -= currentNumber; 
                        }
                        else if (targets[i] != -1 && targets[i] <= currentNumber)
                        {
                            targets[i] += currentNumber;
                        }

                        targets[index] = -1;
                        
                        if (targets[index] != -1)
                        {
                            shotCounter++;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(' ', targets)}");
        }
    }
}
