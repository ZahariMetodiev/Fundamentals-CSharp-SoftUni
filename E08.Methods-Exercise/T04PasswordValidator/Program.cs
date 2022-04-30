using System;

namespace T04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            ValidatePassword(password);
        }

        static void ValidatePassword(string password)
        {
            bool invalid = false;

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }

            if (CheckIfContainsOnlyDigitsAndLatters(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }

            if (DigitsChecker(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }

            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckIfContainsOnlyDigitsAndLatters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static bool DigitsChecker(string password)
        {
            int digitCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];

                if (currentSymbol >= 48 && currentSymbol <= 57)
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
