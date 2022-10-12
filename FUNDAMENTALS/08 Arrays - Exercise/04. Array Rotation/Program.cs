using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rotationCount = int.Parse(Console.ReadLine());

            for (int r = 1; r <= rotationCount; r++)
            {
                int firstEl = arr[0];

                

            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
