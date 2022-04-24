using System;

namespace Т07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double balance = 0;

            while (coins != "Start")
            {
                double currentCoin = double.Parse(coins);

                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    balance += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                
                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();

            double productPrice = 0;
            bool isMoneyLeft = true;

            while (product != "End" || !isMoneyLeft)
            {
                if (product == "Nuts")
                {
                    productPrice = 2;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.80;
                }
                else if (product == "Coke")
                {
                    productPrice = 1;
                }
                

                if (productPrice != 0)
                {
                    if (balance >= productPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        balance -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
