using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmi_lab8_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 3, 2, 4, 1 };
            int n = a.Length;
            stableSelectionSort(a, n);
            printArray(a, n);
            Console.ReadKey();
        }

        private static void printArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
        }

        private static void stableSelectionSort(int[] a, int n)
        {
            // Iterate through array elements
            for (int i = 0; i < n - 1; i++)
            {

                // Loop invariant : Elements till
                // a[i - 1] are already sorted.

                // Find minimum element from
                // arr[i] to arr[n - 1].
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (a[min] > a[j])
                        min = j;

                // Move minimum element at current i.
                int key = a[min];
                while (min > i)
                {
                    a[min] = a[min - 1];
                    min--;
                }

                a[i] = key;
            }
        }
    }
}
