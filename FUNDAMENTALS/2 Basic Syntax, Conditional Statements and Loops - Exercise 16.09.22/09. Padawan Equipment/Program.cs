using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceForLightsabers = double.Parse(Console.ReadLine());
            double priceForRobes = double.Parse(Console.ReadLine());
            double priceForBelts = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int belts = students / 6;
            double students1 = Math.Ceiling((students * 0.1) + students);





            totalPrice = (students1 * priceForLightsabers) + ((students - belts) * priceForBelts) + (students * priceForRobes);

            if (totalPrice > money)
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
            else if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
