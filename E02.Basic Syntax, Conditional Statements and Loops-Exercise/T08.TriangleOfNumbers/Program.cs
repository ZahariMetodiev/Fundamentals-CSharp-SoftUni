using System;

namespace T08TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int  line= 1; line <= num; line++)
            {
                for (int rows = 1; rows <= line; rows++)
                {
                    Console.Write($"{line} ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
