using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
                                    
            int product = 0;

            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    product = num * i;
                    Console.WriteLine($"{num} X {i} = {product}");
                }

            }
            else
            {
                product = num * times;
                Console.WriteLine($"{num} X {times} = {product}");
            }
            
        }
    }
}
