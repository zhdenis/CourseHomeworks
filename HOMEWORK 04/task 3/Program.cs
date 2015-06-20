using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a card: ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":

                    Console.WriteLine("Invalid card");
                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "K":
                case "J":
                case "Q":
            
                    Console.WriteLine("Valid card");
                    break;

                default:
                    Console.WriteLine("Invalid card");
                    break;
            }
        }
    }
}
