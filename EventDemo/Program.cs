using SortLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 3, 5, 1, 2 };

            Sorter.Sort(ar, InAscending);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }

        private static bool InAscending(int i, int j)
        {
            return i > j;
        }

        private static bool InDescending(int i, int j)
        {
            return i < j;
        }
    }
}
