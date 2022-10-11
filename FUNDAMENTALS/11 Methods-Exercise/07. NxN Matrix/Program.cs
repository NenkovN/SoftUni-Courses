using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {


            int n =int.Parse(Console.ReadLine());


            for (int i = 0; i <= n-1; i++)
            {
                for (int r = 1; r <= n-1; r++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine(n + "");
            }
        }
    }
}
