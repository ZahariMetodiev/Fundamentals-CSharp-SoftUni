using System;

namespace T09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int result = GetMaxIntValue();
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char result = GetMaxCharValue();
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMaxStringValue();
                Console.WriteLine(result);
            }
        }

        static int GetMaxIntValue()
        {
            int fyrstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(fyrstNum, secondNum);
            return maxNum;
        }

        static char GetMaxCharValue()
        {
            char fyrstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int maxChar = Math.Max(fyrstChar, secondChar);
            return Convert.ToChar(maxChar);
        }

        static string GetMaxStringValue()
        {
            string fyrst = Console.ReadLine();
            string second = Console.ReadLine();

            int fyrstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < fyrst.Length; i++)
            {
                fyrstSum += fyrst[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                secondSum += second[i];
            }

            if (fyrstSum > secondSum)
            {
                return fyrst;
            }
            return second;
        }
    }
}
