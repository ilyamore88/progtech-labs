using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public int a { get; }
        public int b { get; }
        public int c { get; }

        public Triangle()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }

        public Triangle(int a, int b, int c)
        {
            if (IsExist(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Error!!! Wrong triangle");
            }
        }

        private static bool IsExist(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetPerimeter()
        {
            return this.a + this.b + this.c;
        }

        public double GetArea()
        {
            double p = (double)this.GetPerimeter() / 2;
            double area = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            return area;
        }

        public override string ToString()
        {
            string bs = String.Format("Triangle:\n First side: {0}\n Second side: {1}\n Third side: {2}", this.a, this.b, this.c);
            return bs;
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
