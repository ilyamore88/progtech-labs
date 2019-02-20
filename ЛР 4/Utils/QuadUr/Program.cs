using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadUr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2 + bx + c = 0");
            double x1 = 0, x2 = 0;
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            int countOfAnswers = FindAnswer(a, b, c, ref x1, ref x2);
            if (countOfAnswers == -1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
            }
            else if (countOfAnswers == 0)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = x2 = {3}.", a, b, c, x1);
            }
            else
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}.", a, b, c, x1, x2);
            }
        }

        static int FindAnswer(int a, int b, int c, ref double x1, ref double x2)
        {
            double discr = Math.Pow(b, 2) - 4 * a * c;
            if (discr < 0)
            {
                return -1;
            }
            else if (discr == 0)
            {
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = x1;
                return 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                return 1;
            }
        }
    }
}
