using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("hello ");
            Console.WriteLine("Enter value a -> ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b ->");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            int d = a - b;
            int e = b * c;
            double f = a / d;

            Console.WriteLine("ANS");
            Console.WriteLine("sum -> " + c);
            Console.WriteLine("sub -> " + d);
            Console.WriteLine("mul -> " + e);
            Console.WriteLine("div -> " + f);

            Console.WriteLine("byeee");
        }
    }
}
