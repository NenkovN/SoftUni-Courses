using System;

namespace _06_Middle_Characters
{
    class Program
    {
        static string GetMiddleCharacter(string input)
        {
            int len = input.Length;
            string result = string.Empty;

            if (len % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }

            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacter(input));
        }
    }
}
