using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double totalA = 1;
            double totalB = 1;
            double total = 0;
            for (int i = 1; i < a; i++)
            {
                totalA += totalA * i;
            }
            for (int f = 1; f < b; f++)
            {
                totalB += totalB * f;
            }
            total = totalA / totalB;
            Console.WriteLine($"{total:f2}");
            
        }        
    }
}
