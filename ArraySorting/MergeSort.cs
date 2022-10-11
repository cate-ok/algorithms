using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySorting
{
    public class MergeSort
    {
        // Time Complexity: O(N log(N))
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2; //start + (end - start) / 2;
                Sort(arr, start, mid);
                Sort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }            
        }

        // Merges two subarrays of arr.
        // the merging step requires extra space to store the elements (not in place)
        void Merge(int[]arr, int start, int mid, int end)
        {
            int i, j, 
                k = start; // Initial index of merged subarray array            
            int len1 = mid - start + 1; // length of subarray
            int len2 = end - mid;
            // Temp arrays
            int[] array1 = new int[len1];
            int[] array2 = new int[len2];

            // Copy data to temp arrays
            for (i = 0; i < len1; ++i)
                array1[i] = arr[start + i];
            for (j = 0; j < len2; ++j)
                array2[j] = arr[mid + 1 + j];

            i = 0;
            j = 0;
            while (i < len1 && j < len2)
            {
                if (array1[i] <= array2[j])
                {
                    arr[k] = array1[i];
                    i++;
                }
                else
                {
                    arr[k] = array2[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements if any
            while (i < len1)
            {
                arr[k] = array1[i];
                i++;
                k++;
            }
            while (j < len2)
            {
                arr[k] = array2[j];
                j++;
                k++;
            }
        }
    }
}
