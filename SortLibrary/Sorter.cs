using System;
using System.Collections.Generic;
using System.Text;

namespace SortLibrary
{
    // public delegate bool Swapable(int i, int j);
    public class Sorter
    {
        public static void Sort(int[] ar, Func<int, int, bool> swapable)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j  < ar.Length; j ++)
                {
                    if(swapable(ar[i], ar[j]))
                    {
                        int t = ar[i];
                        ar[i] = ar[j];
                        ar[j] = t;
                    }
                }

            }
        }
    }
}
