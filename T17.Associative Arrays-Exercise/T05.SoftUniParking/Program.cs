using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];

                    if (!cars.ContainsKey(name))
                    {
                        cars.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else
                {
                    if (!cars.ContainsKey(name))
                    {
                        Console.WriteLine("ERROR: user {username} not found");
                    }
                    else
                    {
                        cars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
