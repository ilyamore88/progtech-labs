using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arProg = new ArithmeticProgression(3, 12);
            GeometricProgression geoProg = new GeometricProgression(2, 3);
            Console.Write("Enter number of element: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Element in arithmetic progression is {0}\nElement in geometric progression is {1}", arProg.GetElement(n), geoProg.GetElement(n));
        }
    }
}
