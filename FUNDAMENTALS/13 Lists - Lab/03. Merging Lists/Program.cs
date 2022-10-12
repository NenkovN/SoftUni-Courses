using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> firstColection = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            List <int> secondColection  = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> result = new List<int>();
            int n = Math.Min(firstColection.Count, secondColection.Count);
            for (int i = 0; i < n; i++)
            {
                result.Add(firstColection[i]);
                result.Add(secondColection[i]);
            }


            if (firstColection.Count > secondColection.Count)
            {
                for (int i = n; i < firstColection.Count; i++)
                {
                    result.Add(firstColection[i]);
                }
            }
            else if (secondColection.Count > firstColection.Count)
            {
                for (int i = n; i < secondColection.Count; i++)
                {
                    result.Add(secondColection[i]);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
