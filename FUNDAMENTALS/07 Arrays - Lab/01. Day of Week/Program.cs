using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int num = int.Parse(Console.ReadLine());


            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(days[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}