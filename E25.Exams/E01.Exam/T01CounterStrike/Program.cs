using System;

namespace T01CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int wonGameCounter = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy >= distance)
                {
                    energy -= distance;
                    wonGameCounter++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonGameCounter} won battles and {energy} energy");
                    return;
                }

                if (wonGameCounter % 3 == 0)
                {
                    energy += wonGameCounter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonGameCounter}. Energy left: {energy}");
        }
    }
}
