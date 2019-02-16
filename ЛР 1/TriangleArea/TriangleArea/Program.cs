using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter p");
                int p = Int32.Parse(Console.ReadLine()) / 2;
                if (p <= 0)
                {
                    throw new ArithmeticException();
                }
                double side = p * 2 / 3;
                double area = Math.Sqrt(p * (p - side) * (p - side) * (p - side));
                Console.WriteLine("Side:\tArea:");
                Console.WriteLine("{0:F}\t{1:F}", side, area);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An FormatException was thrown: {0}", e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("An ArithmeticException was thrown: {0}", e.Message);
            }
        }
    }
}
