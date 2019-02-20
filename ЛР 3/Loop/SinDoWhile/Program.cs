using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            double x = x1;
            double y;
            Console.Write("x\t\tsin(x)\n");
            do
            {
                y = Math.Sin(x);
                Console.Write("{0}\t\t{1}\n", x, y);
                x += 0.01;
            } while (x <= x2);
        }
    }
}
