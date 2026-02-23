using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Compound Intrest ");

            Console.WriteLine("Enter Principle value -> ");
            float p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate value -> ");
            float r = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year value -> ");
            float n = int.Parse(Console.ReadLine());

            float simple = p * r * n / 100;
            float total = simple + p;
            float c = total * r / 100;
            float com = c + total;

            Console.WriteLine("Simple           " + simple);
            Console.WriteLine("total simple     " + total);
            Console.WriteLine("Compound         " + c);
            Console.WriteLine("Compound Intrest " + com);
        }
    }
}
