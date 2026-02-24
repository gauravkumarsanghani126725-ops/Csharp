using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number ");
            int no= int.Parse(Console.ReadLine());

            int  m;
            int sum = 0;
            while (no > 0)
            {
                m = no % 10;
                no= no / 10;
                sum = sum + m;

                
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
