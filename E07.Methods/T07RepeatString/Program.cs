using System;

namespace T07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(input, count);
            Console.WriteLine(result);
        }

        static string RepeatString(string text, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
