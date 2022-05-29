using System;

namespace T01ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double tax = 0;
            
            string input = Console.ReadLine();
            
            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += price;
                    tax += price * 0.20;
                }
                
                input = Console.ReadLine();
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double totalSum = sum + tax;

            if (input == "special")
            {
                totalSum *= 0.90;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {tax:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalSum:f2}$");
        }
    }
}
