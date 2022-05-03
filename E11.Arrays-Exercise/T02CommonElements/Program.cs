using System;

namespace T02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write(array1[j] + " ");
                    }
                }
            }
        }
    }
}
