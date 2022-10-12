using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;
            int num = 0;


            for (int i = 1; i <= lines; i++)
            {
                char currCh = char.Parse(Console.ReadLine());
                num = (int)currCh + key;

                char newLetter = (char)num;
                message += newLetter;
            }

             Console.WriteLine(message);
            
        }
    }
}
