using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 1; i <= num; i++)
            {
                decimal n = decimal.Parse(Console.ReadLine());

                total += n;
            }

            Console.WriteLine(total);
        }
    }
}
