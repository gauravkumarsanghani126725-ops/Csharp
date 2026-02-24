using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3p8
{
    internal class Program
    {
        static void Main()
        {
            
            int[] a = new int[10];

            Console.WriteLine("Enter 10 Value");


            int i;
            for (i = 0; i < 10; i++)
            {
                a[i]=int.Parse(Console.ReadLine());

            }
            Console.WriteLine("revers number");
            for (i=a.Length-1; i>=0; i--)
            {
                
                Console.WriteLine(a[i]);
            }
        }
    }
}
