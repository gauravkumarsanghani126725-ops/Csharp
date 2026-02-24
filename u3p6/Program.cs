using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter start number:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end number:");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = n; i <= n1; i++)
            {
                int div = 0;


                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        div++;
                    }
                }


                if (div == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
