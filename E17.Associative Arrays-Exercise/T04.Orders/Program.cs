using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productsInformation = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] products = input.Split().ToArray();
                
                string name = products[0];
                double price = double.Parse(products[1]);
                double quantity = double.Parse(products[2]);

                if (!productsInformation.ContainsKey(name))
                {
                    productsInformation.Add(name, new List<double>() { price, quantity });
                }
                else
                {
                    productsInformation[name][0] = price;
                    productsInformation[name][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in productsInformation)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
