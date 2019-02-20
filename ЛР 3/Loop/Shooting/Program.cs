using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;
            int sum = 0;
            Random rand = new Random();
            int centerX = rand.Next(-1, 1);
            int centerY = rand.Next(-1, 1);
            Console.Write("Number of shots: ");
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n], y = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                x[i] = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y[i] = int.Parse(Console.ReadLine());
                if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 1)
                {
                    Console.WriteLine("Wow! 10 points!");
                    sum += 10;
                }
                else if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 4)
                {
                    Console.WriteLine("Not bad. 5 point.");
                    sum += 5;
                }
                else if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 9)
                {
                    Console.WriteLine("1 point.");
                    sum += 1;
                }
                else
                {
                    Console.WriteLine("Miss!");
                }
            }
            Console.WriteLine("Total score: {0}", sum);
        }
    }
}
