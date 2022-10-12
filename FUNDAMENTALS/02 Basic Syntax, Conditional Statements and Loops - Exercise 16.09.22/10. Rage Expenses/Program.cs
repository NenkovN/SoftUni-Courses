using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsedPrice = double.Parse(Console.ReadLine());
            double mouseprice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;


            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    headset++;
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboard++;
                }
                if (i % 12 == 0)
                {
                    display++;
                }

            }
            double total = (headset * headsedPrice) + (mouse * mouseprice) + (keyboard * keyboardPrice) + (display * displayPrice);
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
