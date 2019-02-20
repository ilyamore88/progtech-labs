using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является число {2}", x, y, greater);
            Console.WriteLine("До swap: \t{0} {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t{0} {1}", x, y);
            int f;
            bool ok;
            Console.Write("Number for factorial: ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
            {
                Console.WriteLine("Factorial({0}) = {1}", x, f);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }
        }
    }
}
