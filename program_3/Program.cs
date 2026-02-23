using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace program_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple intrest ");

            Console.WriteLine("Enter Principle value -> ");
            float p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate value -> ");
            float r = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year value -> ");
            float y = int.Parse(Console.ReadLine());

            double s = p * r * y / 100 ;

            Console.WriteLine("Simple " + s);

        }
    }
}
