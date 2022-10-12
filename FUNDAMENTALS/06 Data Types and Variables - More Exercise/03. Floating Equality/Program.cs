using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool isEqual = Math.Abs(n - n2) < eps;


            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    }
}
