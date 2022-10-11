using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

          int total = 0;

          total = num * num2 * num3;

            if (total < 0)
            {
                Console.WriteLine("negative");
            }
            else if (total > 0)
            {
                Console.WriteLine("positive");
            }
            else if (total == 0)
            {
                Console.WriteLine("zero");
            }          
        }
    }
          
}
