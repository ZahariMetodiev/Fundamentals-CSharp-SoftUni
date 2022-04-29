using System;

namespace T02Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            
            string result = Grades(grade);

            Console.WriteLine(result);
        }

        static string Grades(double grade)
        {
            
            string sign = string.Empty;

            if (grade >= 2 && grade <= 2.99)
            {
                sign = "Fail";
            }
            else if (grade <= 3.49)
            {
                sign = "Poor";
            }
            else if (grade <= 4.49)
            {
                sign = "Good";
            }
            else if (grade <= 5.49)
            {
                sign = "Very good";
            }
            else if (grade <= 6)
            {
                sign = "Excellent";
            }

            return sign;
        }
    }
}
