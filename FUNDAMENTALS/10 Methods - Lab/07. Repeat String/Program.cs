using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word =Console.ReadLine();
            int n =int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.Write(word);
            }
        }
    }
}
