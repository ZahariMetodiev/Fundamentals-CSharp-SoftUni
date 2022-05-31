using System;
using System.Collections.Generic;
using System.Linq;

namespace Т02ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = input.Split();

                string item = commands[1];

                if (commands[0] == "Urgent")
                {
                    if (!(products.Contains(item)))
                    {
                        products.Insert(0, item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Unnecessary")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Correct")
                {
                    string newItem = commands[2];

                    if (products.Contains(item))
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i] == item)
                            {
                                products[i] = newItem;
                                break;
                            }
                        }
                    }
                }
                else if (commands[0] == "Rearrange")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
