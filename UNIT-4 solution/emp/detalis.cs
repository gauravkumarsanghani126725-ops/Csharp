using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
    internal class detalis
    {
        int eid;
        int econ;
        String ename;
        public void emp_detalis()
        {
            Console.WriteLine("Enter Employee Name  --> ");
            ename = Console.ReadLine();

            Console.WriteLine("Enter Employee Contact Number --> ");
            econ = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Employee id--> ");
            eid = Convert.ToInt32(Console.ReadLine());

        }

        public void display()
        {
            Console.WriteLine("Employee Name is -->" + ename);
            Console.WriteLine("Employee Contact Number  is -->" + econ);
            Console.WriteLine("Employee Id is -->" + eid);
        }

    }
}
