using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] number = new int[wagons];

            int total = 0;
            for (int i = 0; i < wagons; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                number[i] = numbers;
                total += numbers;


            }
            Console.WriteLine(string.Join(" ", number));
            Console.WriteLine(total);
        
        }
    }
}