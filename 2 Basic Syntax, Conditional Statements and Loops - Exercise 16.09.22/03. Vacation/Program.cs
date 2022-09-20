using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            double AmountOfPeople = double.Parse(Console.ReadLine());
            string Group = Console.ReadLine();
            string Day = Console.ReadLine();

            if (Group == "Students")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 8.45;
                }
                else if (Day == "Saturday")
                {
                    price = 9.80;
                }
                else if (Day == "Sunday")
                {
                    price = 10.46;
                }

                if (AmountOfPeople >= 30)
                {
                    double total = (AmountOfPeople * price)*0.85;
                    
                    Console.WriteLine($"Total price: {total:F2}");
                }
                else
                {
                    double total = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {total:F2}");
                }
            }
            else if (Group == "Business")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 10.90;
                }
                else if (Day == "Saturday")
                {
                    price = 15.60;
                }
                else if (Day == "Sunday")
                {
                    price = 16;
                }

                if (AmountOfPeople >= 100)
                {
                    double total = (AmountOfPeople-10)*price;
                    Console.WriteLine($"Total price: {total:F2}");
                }
                else
                {
                    double total = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {total:F2}");
                }


            }
            else if (Group == "Regular")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 15;
                }
                else if (Day == "Saturday")
                {
                    price = 20;
                }
                else if (Day == "Sunday")
                {
                    price = 22.50;
                }

                if (AmountOfPeople >= 10 && AmountOfPeople <= 20)
                {
                    double total = (price * AmountOfPeople)*0.95;
                    
                    Console.WriteLine($"Total price: {total:F2}");
                }
                else
                {
                    double total = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {total:F2}");
                }
            }
        }
    }
}