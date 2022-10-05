using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product =Console.ReadLine();
            int number =int.Parse(Console.ReadLine());
            double total = 0;

            if (product=="coffee")
            {
                total = 1.50 * number;
            }
            else if(product=="water")
            {
                total = 1.00 * number;
            }
            else if (product == "coke")
            {
                total = 1.40 * number;
            }
            else if (product == "snacks")
            {
                total = 2.00 * number;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
