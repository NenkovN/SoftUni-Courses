using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            if (input=="int")
            {
                int num =int.Parse(Console.ReadLine());
                total = num * 2;
                Console.WriteLine(total);
            }
            else if (input == "real")
            {
                double num =double.Parse(Console.ReadLine());
                total = num * 1.5;
                Console.WriteLine($"{total:f2}");
            }
            else
            {
               input =Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }
    }        
}
