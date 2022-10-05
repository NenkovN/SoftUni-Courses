using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

        }

        private static void NewMethod()
        {
            int n1 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());
            double total = 0;
            if (oper == "/")
            {
                total = n1 / n2;
            }
            else if (oper == "*")
            {
                total = n1 * n2;
            }
            else if (oper == "+")
            {
                total = n1 + n2;
            }
            else if (oper == "-")
            {
                total = n1 - n2;
            }
            Console.WriteLine(total);
        }
    }
}
