using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = raiseToPower(number, power);
            Console.WriteLine(result);
        }
        private static double raiseToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
