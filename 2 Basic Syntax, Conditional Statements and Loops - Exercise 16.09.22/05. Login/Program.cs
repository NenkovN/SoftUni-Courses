using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length-1; i>= 0; i--)
            {
                char currCh = userName[i];
                password += currCh;
            }

            int tries = 0;
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password) 
            {
                tries++;
                if (tries>=4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                        break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    
                }

            }
            if (tries < 4)
            { 
                Console.WriteLine($"User {userName} logged in."); 
            }
           
        }
    }
}
