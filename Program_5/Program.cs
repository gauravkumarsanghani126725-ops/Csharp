using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("circle Area");

            Console.WriteLine("Enter r value ");
            float r = int.Parse(Console.ReadLine());

            float pi = 3.14f;

            float c = pi * r * r;

            Console.WriteLine("Area of Circle is --> " + c);

        }
    }
}
