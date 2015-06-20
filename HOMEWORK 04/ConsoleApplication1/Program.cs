using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int y = int.Parse(Console.ReadLine());
          
            if (y >=1 && y <= 3)
            {
                 int x = y * 5;
                 Console.WriteLine(x);
            }

            else if (y >= 4 && y <= 6)
            {
                int x = y * 10;
                Console.WriteLine(x);
            }

            else if (y >= 7 && y <= 9)
            {
                int x = y * 50;
                Console.WriteLine(x);
            }

            else
            {
                Console.WriteLine("Not possible");
            }
            
        }
    }
}
