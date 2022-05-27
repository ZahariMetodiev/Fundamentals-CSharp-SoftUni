using System;
using System.Collections.Generic;
using System.Text;

namespace T04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morse = new Dictionary<string, char>()
            {
                {".-",'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'} ,
                {".",'E'},
                {"..-.",'F'},
                {"--.",'G'} ,
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'} ,
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'} ,
                {"---",'O'} ,
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S'} ,
                {"-",'T'} ,
                {"..-",'U'} ,
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                { "--..",'Z'},
            };

            string[] morseCode = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder message = new StringBuilder();

            foreach (var symbol in morseCode)
            {
                message.Append(symbol == "|" ? ' ' : morse[symbol]);
            }

            Console.WriteLine(message);
        }
    }
}
