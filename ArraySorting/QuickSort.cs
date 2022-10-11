using System;

namespace ArraySorting
{
    /// <summary>
    /// Time Θ(n log(n))
    /// </summary>
    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length-1);
        }

        void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Get index of element that is on the right place already
                var p = DoPartition(arr, low, high); // partitioning index

                Sort(arr, 0, p - 1);    // part of array before p
                Sort(arr, p + 1, high);  // part of array after p
            }                
        }

        int DoPartition(int[] arr, int low, int high)
        {
            var pivot = arr[high]; // Element to be placed at right position
            int temp;

            int i = (low-1); // Index of smaller element and indicates the 
                             // right position of pivot found so far

            for (var j=low; j<high; j++)
            {
                if (arr[j] < pivot) // If current element is smaller than the pivot
                {
                    i++; // increment index of smaller element
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            var newPivotIndex = (i + 1);
            // Put pivot into right position
            temp = arr[newPivotIndex];
            arr[newPivotIndex] = arr[high];
            arr[high] = temp;

            return newPivotIndex;
        }
    }
}
