using System.Net.Http.Headers;

namespace DotNetProgram.Basics
{
    class Basics{
        public static void Maing(string[] argss)
        {   

           Retry: 
           Console.Write("Enter a number: ");
           string? a = Console.ReadLine();
           switch (a)
           {
                case "1":
                    Console.WriteLine("number not 1");
                    goto Retry;
                case "2":
                    Console.WriteLine("number not 2");
                    goto Retry;
                case "3":
                    Console.WriteLine("number is 3");
                    break;
                case "4":
                    Console.WriteLine("number not 4");
                    goto Retry;
                    
           }
        }
    }
}