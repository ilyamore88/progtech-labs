using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public struct Distance
    {
        public int foot;
        public int inch;

        public Distance(int foot, int inch)
        {
            this.foot = foot + (int)(inch / 12);
            this.inch = inch % 12;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first distance");
            Distance dist1 = new Distance(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Enter second distance");
            Distance dist2 = new Distance(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Distance dist3 = new Distance(dist1.foot + dist2.foot + (int)((dist1.inch + dist2.inch) / 12), (dist1.inch + dist2.inch) % 12);
            Console.WriteLine("Sum: {0}\'- {1}\"", dist3.foot, dist3.inch);
        }
    }
}
