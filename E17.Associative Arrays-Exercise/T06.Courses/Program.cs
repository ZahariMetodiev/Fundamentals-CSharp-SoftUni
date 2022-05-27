using System;
using System.Collections.Generic;
using System.Linq;

namespace Т06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitedInput = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = splitedInput[0];
                string studentName = splitedInput[1];

                if (!students.ContainsKey(courseName))
                {
                    students.Add(courseName, new List<string>());
                }

                students[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value.Count}");

                foreach (var item in student.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
