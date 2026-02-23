using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your age ");
            int a = int.Parse(Console.ReadLine());

            if(a < 12)
            {
                Console.WriteLine("You are kid");
            }
            else if(a >= 12 && a <= 17)
            {
                Console.WriteLine("you are Teenager");
                
            }
            else if (a >= 18 && a <= 60)
            {
                Console.WriteLine("you are adult");
            }

            else 
            {
                Console.WriteLine("you are senior citizen");
            }

        }
    }
}
