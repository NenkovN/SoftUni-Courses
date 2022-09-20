using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string word2 = string.Empty;

            for (int i = word.Length-1; i >= 0; i--)
            {
                word2 += word[i];
            }
            Console.WriteLine(word2);
        }
    }
}
