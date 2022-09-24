using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersN = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsules = int.Parse(Console.ReadLine());

            double total = 0;
            double coffieTotal = 0;
            double count = 0;

            for (int i = 1; i <= ordersN; i++)
            {
                count++;
                total = ((days * capsules) * price);

                Console.WriteLine($"The price for the coffee is: ${total:f2}");


                coffieTotal += total;
                if (count < ordersN) 
                {
                    price = double.Parse(Console.ReadLine());
                    days = int.Parse(Console.ReadLine());
                    capsules = int.Parse(Console.ReadLine());
                }
                
                
            }
            Console.WriteLine($"Total: ${coffieTotal:f2}");
        }
    }
}
