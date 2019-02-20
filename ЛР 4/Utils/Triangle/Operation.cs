using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Operation
    {
        public static double GetArea(int a, int b, int c)
        {
            if (IsTriangle(a, b, c))
            {
                double area;
                double p = (double)(a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return area;
            }
            else
            {
                return 0;
            }
        }

        public static double GetArea(int a)
        {
            if (IsTriangle(a))
            {
                return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
            }
            else
            {
                return 0;
            }
        }

        private static bool IsTriangle(int a, int b, int c)
        {
            if ((a > 0 && b > 0 && c > 0) && (a + b > c && b + c > a && c + a > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsTriangle(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
