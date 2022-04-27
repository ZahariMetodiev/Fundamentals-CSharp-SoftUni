using System;

namespace T03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int numberOfCourses = numberOfPeople / elevatorCapacity;

            if (numberOfPeople % elevatorCapacity != 0)
            {
                numberOfCourses++;
            }

            Console.WriteLine(numberOfCourses);
        }
    }
}
