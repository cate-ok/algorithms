using System;

namespace ArraySorting
{
    /// <summary>
    /// time O(n^2)
    /// </summary>
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
