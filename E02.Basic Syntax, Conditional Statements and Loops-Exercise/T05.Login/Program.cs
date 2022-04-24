using System;
using System.Linq;

namespace T05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();

            int counter = 1;

            while (password != input)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                
                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
                counter++;
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
