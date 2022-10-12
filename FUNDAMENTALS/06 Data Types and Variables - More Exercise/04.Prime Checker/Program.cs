using System;

namespace _04.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true) 
                {
                    Console.WriteLine($"{i} -> true ");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }

        }
    }
}
