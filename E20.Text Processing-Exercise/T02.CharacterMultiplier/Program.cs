using System;

namespace T02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            string firstWord = words[0];
            string secondWord = words[1];

            int minLenght = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = minLenght; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }
            else
            {
                for (int i = minLenght; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
