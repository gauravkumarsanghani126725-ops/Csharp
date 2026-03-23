using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.calculate();
            r1.Display();

            Rectangle r2 = new Rectangle(30,40);
            r2.calculate();
            r2.Display();
        }
    }
}
