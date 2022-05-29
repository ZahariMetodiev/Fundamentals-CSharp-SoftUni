using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool noMorePeople = false;
            bool leftedSpace = false;
            int maxCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] >= 4)
                {
                    waitingPeople -= maxCapacity;
                    wagons[i] = maxCapacity;
                }
                else if (wagons[i] <= 0)
                {
                    if (waitingPeople - maxCapacity < 0)
                    {
                        wagons[i] = waitingPeople;
                        waitingPeople -= wagons[i];
                    }
                    else
                    {
                        wagons[i] = maxCapacity;
                        waitingPeople -= wagons[i];
                    }
                }
                else
                {
                    waitingPeople -= maxCapacity - wagons[i];
                    wagons[i] = maxCapacity;
                }

                if (waitingPeople <= 0)
                {
                    noMorePeople = true;
                    break;
                }
            }

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < maxCapacity)
                {
                    leftedSpace = true;
                    break;
                }
            }

            if (noMorePeople && leftedSpace)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else if (!(leftedSpace) && waitingPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else
            {
                Console.WriteLine(string.Join(' ', wagons));
            }
        }
    }
}