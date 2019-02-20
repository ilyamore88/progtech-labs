using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapeifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 9 && y > 0)
            {
                Console.WriteLine("Inside");
            }
            else if (x * x + y * y > 9 || y < 0)
            {
                Console.WriteLine("Outside");
            }
            else
            {
                Console.WriteLine("On the border");
            }
        }
    }
}
