using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());

            getColsedToTheCenterPoint(firstNum, secondNum, thirdNum, fourthNum);
        }

        private static void getColsedToTheCenterPoint(double firstNum, double secondNum, double thirdNum, double forthNum)
        {

            double firstResult = Math.Max(Math.Abs(firstNum), Math.Abs(secondNum));
            double secondResult = Math.Max(Math.Abs(thirdNum), Math.Abs(forthNum));


            if (firstResult <= secondResult)
            {
                Console.WriteLine($"({firstNum}, {secondNum})");
            }
            else
            {
                Console.WriteLine($"({thirdNum}, {forthNum})");
            }

        }
    }
}