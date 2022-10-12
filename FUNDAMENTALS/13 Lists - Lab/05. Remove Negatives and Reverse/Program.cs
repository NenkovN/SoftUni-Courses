using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            List <int> num = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            num.RemoveAll(x => x < 0);
            
            num.Reverse();
            if (num.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",num));
            }

        }
    }
}
