using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Sorting
{
    public class Sorter
    {
        public int[] BubbleSort(int[] a)
        {
            int temp;
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {                    
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;                        
                    }
                }
            }
            return a;
        }

        public int Pairs(int k, int[] arr)
        {
            int count = 0;

            HashSet<int> hs = new HashSet<int>();
            for (var i = 0; i < arr.Length; i++)
            {
                hs.Add(arr[i]);
            }
            foreach(var el in hs)
            {
                count += hs.Contains(el + k) ? 1 : 0;
            }
            return count;
        }

    }
}
