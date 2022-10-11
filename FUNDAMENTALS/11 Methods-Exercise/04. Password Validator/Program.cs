using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputPasswod = Console.ReadLine();

            bool isLenthValid = isPasswordLengthValid(inputPasswod);
            bool isppasswordAlpha = isPasswordAlphaNumeric(inputPasswod);
            bool has2Digidts = isPassword2digits(inputPasswod);

            if (!isLenthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isppasswordAlpha)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!has2Digidts)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLenthValid && isppasswordAlpha && has2Digidts)
            {
                Console.WriteLine("Password is valid");
            }
        }

         static bool isPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool isPasswordAlphaNumeric(string passwod)
        {
            foreach (char ch in passwod)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool isPassword2digits(string passwod)
        {
            int digitCount = 0;
            foreach (char ch in passwod)
            {
                if (Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            return digitCount >= 2;
        }
    }
}
