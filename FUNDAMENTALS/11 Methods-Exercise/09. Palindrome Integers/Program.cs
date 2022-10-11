using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string  input = Console.ReadLine();
            string reverse = String.Empty;

            while (input != "END")
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i];
                }
                if (input != reverse) 
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }

                reverse = string.Empty;
                input =Console.ReadLine();
        }   }
    }
}
