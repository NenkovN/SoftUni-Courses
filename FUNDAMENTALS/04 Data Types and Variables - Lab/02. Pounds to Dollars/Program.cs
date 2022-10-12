using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {

            double pound = double.Parse(Console.ReadLine());

            double US = pound * 1.31;

            Console.WriteLine($"{US:f3}");
            
        }
    }
}
