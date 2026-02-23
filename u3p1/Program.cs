using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number --> ");
            int a = int.Parse(Console.ReadLine());

            if(a%2 == 0)
            {
                Console.WriteLine("Number is even");
            }

            else
            {
                Console.WriteLine("Number is odd");

            }
        }
    }
}
