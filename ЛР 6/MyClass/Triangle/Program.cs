using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle();
            tr1.Print();
            Console.WriteLine("GetArea(): {0}", tr1.GetArea());
            Console.WriteLine("GetPerimeter(): {0}", tr1.GetPerimeter());
            Triangle tr2 = new Triangle(3, 4, 5);
            tr2.Print();
            Console.WriteLine("GetArea(): {0}", tr2.GetArea());
            Console.WriteLine("GetPerimeter(): {0}", tr2.GetPerimeter());
        }
    }
}
