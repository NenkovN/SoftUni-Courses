using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {


            int n =int.Parse(Console.ReadLine());
            

            int waterTank = 255;
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (waterTank >=liters)
                {
                    waterTank -= liters;
                    total += liters;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(total); ;
            Console.ReadKey();
        }
    }
}
