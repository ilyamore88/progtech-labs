using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            } while (i <= n);
            Console.Write("\nfor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] % 2 == 0) myArray[j] = 0;
                Console.Write(myArray[j] + " ");
            }
            Console.WriteLine();
            int[] myArray2;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            myArray2 = new int[n];
            for (int j = 0; j < myArray2.Length; j++)
            {
                Console.Write("a[{0}] = ", j);
                myArray2[j] = int.Parse(Console.ReadLine());
            }
            foreach (int x in myArray2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
