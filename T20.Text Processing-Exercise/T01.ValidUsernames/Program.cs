using System;
using System.Linq;

namespace T01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var username in usernames)
            {

                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    foreach (var symbol in username)
                    {
                        if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }

    }
}
