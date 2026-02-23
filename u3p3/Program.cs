using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace u3p3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("factorial");

            Console.WriteLine("Enter Number ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = n; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial --> " + fact);


        }
    }
}
