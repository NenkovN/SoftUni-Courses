using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string cal =Console.ReadLine();
            int num =int.Parse(Console.ReadLine());
            int num2 =int.Parse(Console.ReadLine());
            int total = 0;

            if (cal == "subtract")
            {
                total = num - num2;
            }
            else if (cal == "multiply")
            {
                total = num * num2;
            }
            else if (cal == "add")
            {
                total = num + num2;
            }
            else if (cal == "divide")
            {
                total = num / num2;
            }

            Console.WriteLine(total);
        }
    }
}
