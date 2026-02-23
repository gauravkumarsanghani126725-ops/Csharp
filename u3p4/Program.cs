using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("");


            Console.WriteLine("Enter Number ");
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            

            Console.Write(n1  +  "  ");
            Console.Write(n2  +  "  ");
            int n3 = 0;

            while (n3 <= n)
            {
                
                Console.Write(n3 + "  ");
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }

        }
    }
}
