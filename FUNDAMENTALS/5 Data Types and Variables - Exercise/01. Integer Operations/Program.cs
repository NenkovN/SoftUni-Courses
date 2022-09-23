using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());
            long n3 = long.Parse(Console.ReadLine());
            long n4 = long.Parse(Console.ReadLine());

            long total = 0
                ;
            total = ((n1 + n2) / n3) * n4;

            Console.WriteLine($"{total}");          
        }
    }
}
