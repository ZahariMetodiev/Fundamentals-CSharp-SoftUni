using System;

namespace T03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine();
            string text = Console.ReadLine();

            int startIndex = text.IndexOf(bannedWord);

            while (startIndex != -1)
            {
                text = text.Remove(startIndex, bannedWord.Length);
                startIndex = text.IndexOf(bannedWord);
            }

            Console.WriteLine(text);
        }
    }
}
