using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	It should contain 6 – 10 characters(inclusive)
            //•	It should contain only letters and digits
            //•	It should contain at least 2 digits
            //logIn
            string inputPass = Console.ReadLine();
            int minLenght = 6;
            int maxLenght = 10;
            int MinDigitCount = 2;
            bool isValid = IsPassValid(inputPass, minLenght, maxLenght, MinDigitCount);
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPassValid(string pass, int minLenght, int maxLenght, int MinDigitCount)
        {
            bool isValid = true;
            if (!PassLenght(pass, minLenght, maxLenght))
            {
                Console.WriteLine($"Password must be between {minLenght} and {maxLenght} characters");
                isValid = false;
            }
            if (!PassAlphaNumeric(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!PassDigitsCount(pass, MinDigitCount))
            {
                Console.WriteLine($"Password must have at least {MinDigitCount} digits");
            }
            return isValid;
        }
        static bool PassLenght(string pass, int minLenght, int maxLenght)
        {

            if (!(pass.Length >= minLenght && pass.Length <= maxLenght))
            {
                return false;
            }
            return true;
        }
        static bool PassAlphaNumeric(string pass)
        {
            foreach (char ch in pass)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool PassDigitsCount(string pass, int MinDigitCount)
        {
            int counter = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    counter++;
                }
            }
            if (!(counter >= 2))
            {
                return false;
            }
            return true;
        }
    }
}
