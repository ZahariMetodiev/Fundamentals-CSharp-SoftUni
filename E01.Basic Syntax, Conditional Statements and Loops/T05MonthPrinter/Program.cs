using System;

namespace T05MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string month = "";

            switch (input)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }

            if (input < 1 || input > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(month);
            }
        }
    }
}