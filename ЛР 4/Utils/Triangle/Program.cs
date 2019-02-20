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
            Console.Write("Введите тип треугольника (1 - равносторонний, 2 - обыкновенный): ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Write("Введите сторону треугольника: ");
                    int x = int.Parse(Console.ReadLine());
                    double area = Operation.GetArea(x);
                    if (area != 0)
                    {
                        Console.WriteLine("Площадь треугольника - {0}", area);
                    }
                    else
                    {
                        Console.WriteLine("Такого трекгольника не существует!");
                    }
                    break;
                case 2:
                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    int c = int.Parse(Console.ReadLine());
                    area = Operation.GetArea(a, b, c);
                    if (area != 0)
                    {
                        Console.WriteLine("Площадь треугольника - {0}", area);
                    }
                    else
                    {
                        Console.WriteLine("Такого трекгольника не существует!");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка ввода!");
                    break;
            }
        }
    }
}
