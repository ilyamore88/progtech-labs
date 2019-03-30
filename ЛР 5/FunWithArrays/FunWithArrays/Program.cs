using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n = 1;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}", GetSum(a));
            Console.WriteLine("Average = {0}", GetAverage(a));
            Console.WriteLine("Sum of positives = {0}", GetSumOfPositives(a));
            Console.WriteLine("Sum of evenes = {0}", GetSumOfEvenes(a));
            Console.WriteLine("Index of min = {0}", FindIndexOfMin(a));
            Console.WriteLine("Index of max = {0}", FindIndexOfMax(a));
            Console.WriteLine("Multiply from min to max = {0}", GetMultiplyFromMinToMax(a));
        }

        private static int GetSum(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
            {
                sum += x;
            }
            return sum;
        }

        private static double GetAverage(int[] a)
        {
            return ((double)GetSum(a) / a.Length);
        }

        private static int GetSumOfPositives(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
            {
                if (x > 0) sum += x;
            }
            return sum;
        }

        private static int GetSumOfEvenes(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0) sum += a[i];
            }
            return sum;
        }

        private static int FindIndexOfMin(int[] a)
        {
            int min = a[0];
            int index = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }
            return index;
        }

        private static int FindIndexOfMax(int[] a)
        {
            int max = a[0];
            int index = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }

        private static int GetMultiplyFromMinToMax(int[] a)
        {
            int multiply = 1;
            int indexMin = FindIndexOfMin(a);
            int indexMax = FindIndexOfMax(a);
            if (indexMin > indexMax)
            {
                int temp = indexMin;
                indexMin = indexMax;
                indexMax = temp;
            }
            for (int i = indexMin; i <= indexMax; i++)
            {
                multiply *= a[i];
            }
            return multiply;
        }
    }
}
