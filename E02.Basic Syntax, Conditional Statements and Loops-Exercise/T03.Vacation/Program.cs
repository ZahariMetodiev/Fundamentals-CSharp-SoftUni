using System;

namespace T03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double singlePrice = 0;

            switch (groupType)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        singlePrice = 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePrice = 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePrice = 10.46;
                    }
                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        singlePrice = 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePrice = 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePrice = 16;
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        singlePrice = 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        singlePrice = 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        singlePrice = 22.50;
                    }
                    break;
            }

            double totalPrice = singlePrice * countOfPeople;

            if (groupType == "Students" && countOfPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (groupType == "Business" && countOfPeople >= 100)
            {
                totalPrice -= singlePrice * 10;
            }
            else if (groupType == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
