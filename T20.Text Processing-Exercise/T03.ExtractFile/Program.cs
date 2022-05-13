using System;

namespace T03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {'\\', '.'}, StringSplitOptions.RemoveEmptyEntries);

            string fileName = input[input.Length -2];
            string extension = input[input.Length-1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
