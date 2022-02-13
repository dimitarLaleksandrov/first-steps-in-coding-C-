using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passMinLength = 6;
            const int passMaxLength = 10;
            const int minPassDigits = 2;
            string password = Console.ReadLine();
            bool isPassValide = PasssChecker(password, passMinLength, passMaxLength, minPassDigits);
            if (isPassValide)
            {
                Console.WriteLine($"Password is valid");
            }
        }
        static bool PasssChecker(string password, int passMinLength, int passMaxLength, int minPassDigits)
        {
            bool isPasssValid = true;
            
            if (!CheckLength(password, passMinLength, passMaxLength))
            {
                Console.WriteLine($"Password must be between {passMinLength} and {passMaxLength} characters");
                isPasssValid = false;
            }
            if (!CheckLettersDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasssValid = false;
            }
            if (!CheckingMinNumOfDigits(password, minPassDigits))
            {
                Console.WriteLine($"Password must have at least {minPassDigits} digits");
                isPasssValid = false;
            }
            return isPasssValid;
        }
        static bool CheckLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckLettersDigits(string password)
        {
            foreach (char charr in password)
            {
                if (!char.IsLetterOrDigit(charr))
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckingMinNumOfDigits(string password, int minDigits)
        {
            int digitsCounter = 0;
            foreach (char charr in password)
            {
                if (char.IsDigit(charr))
                {
                    digitsCounter++;
                }
            }
            return digitsCounter >= minDigits;
        }
    }
}
