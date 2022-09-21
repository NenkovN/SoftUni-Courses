using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());

            double KM = meter / 1000;
            
            Console.WriteLine($"{KM:f2}");

        }
    }
}
