using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {


            List <int> num = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();


            string input =Console.ReadLine();


            while (input!="end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command=="Add")
                {
                    int value = int.Parse(inputParams[1]);
                    num.Add(value);
                }
                else if (command=="Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    num.Remove(value);
                }
                else if (command=="RemoveAt")
                {
                    int value = int.Parse(inputParams[1]);
                    num.RemoveAt(value);
                }
                else if (command=="Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    num.Insert(index,value);
                }           

                    input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
