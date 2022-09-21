using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenth, width, heights, volume = 0;

            lenth = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());            
            heights = double.Parse(Console.ReadLine());

            double lice = lenth * width;
            volume = (lice * heights) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
           
        }
    }
}
