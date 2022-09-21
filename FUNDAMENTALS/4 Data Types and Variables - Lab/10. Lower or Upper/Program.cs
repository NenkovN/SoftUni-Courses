using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string leter = Console.ReadLine();


            switch (leter)
            {
                case "A":                 
                case "B":                    
                case "C":
                case "D":
                case "E":
                case "F":
                case "G":
                case "H":                    
                case "I":
                case "J":                    
                case "K":                    
                case "L":                    
                case "M":                   
                case "N":                   
                case "O":                  
                case "P":                    
                case "Q":                    
                case "R":
                case "S":                    
                case "T":                    
                case "U":                    
                case "V":                   
                case "W":                  
                case "X":                    
                case "Y":                    
                case "Z":
                    Console.WriteLine($"upper-case");
                    break;                   
                 
                default:
                    Console.WriteLine($"lower-case");
                    break;
            }
        }
    }
}
