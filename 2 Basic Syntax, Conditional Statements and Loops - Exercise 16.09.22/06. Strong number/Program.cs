using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int numCoppy = n;
            int factorialSum = 0;

            while (numCoppy > 0)
            {
                int lastDigit = numCoppy % 10;
                numCoppy /= 10;

                int factpral = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    factpral *= i;
                }
                factorialSum += factpral;

            }

            if (factorialSum == n) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }



        }
    }
}
