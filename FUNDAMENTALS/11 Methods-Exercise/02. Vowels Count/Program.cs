using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int vowelsCount = 0;

            for (int i = 0; i <= word.Length-1; i++)
            {
                if ((word[i] == 'a') || (word[i] == 'e') || (word[i] == 'i') || (word[i] == 'u') || (word[i] == 'o'))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);

        }
    }
}
