using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Number ");
            int n = int.Parse(Console.ReadLine());

            int m ;
            int flag = 0;
            for (int i = 2;i <= n;i++)
            {
                m = n % i;

                if (m == 0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = 1;
       
                    break;
                }
            }

            if (flag == n) 
            {
                Console.WriteLine("prime number ");
            }




        }
    }
}
