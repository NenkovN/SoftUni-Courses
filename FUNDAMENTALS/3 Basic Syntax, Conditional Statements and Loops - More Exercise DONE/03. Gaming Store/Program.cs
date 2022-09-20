using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalspend = 0;

            while (input!="Game Time")
            {
                if (input == "OutFall 4" || input == "CS: OG" || input == "Zplinter Zell" || input == "Honored 2" || input == "RoverWatch" || input == "RoverWatch Origins Edition")
                {
                    if (input == "OutFall 4")
                    {
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 39.99;
                            balance -= 39.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }
                    if (input == "CS: OG")
                    {
                        if (balance >= 15.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 15.99;
                            balance -= 15.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }
                    if (input == "Zplinter Zell")
                    {
                        if (balance >= 19.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 19.99;
                            balance -= 19.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }
                    if (input == "Honored 2")
                    {
                        if (balance >= 59.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 59.99;
                            balance -= 59.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }
                    if (input == "RoverWatch")
                    {
                        if (balance >= 29.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 29.99;
                            balance -= 29.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }
                    if (input == "RoverWatch Origins Edition")
                    {
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {input}");
                            totalspend += 39.99;
                            balance -= 39.99;

                        }
                        else
                        {
                            Console.WriteLine($"Too Expensive");

                        }

                    }

                }
                else if (input != "Game Time")
                {
                    Console.WriteLine("Not Found");
                   
                }
               

                if (balance<=0)
                {
                    Console.WriteLine("Out of money");
                        break;
                }
                

                input = Console.ReadLine();
            }


            Console.WriteLine($"Total spent: ${totalspend:f2}. Remaining: ${balance:f2}");


        }
    }
}
