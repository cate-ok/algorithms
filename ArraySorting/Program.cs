using System;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            int[] arr1 = { 4, 8, 3, 1, 10, 6, 2, 3 };
            BubbleSort bs = new BubbleSort();
            bs.Sort(arr1);
            PrintArray(arr1);
            Console.WriteLine();

            Console.WriteLine("Quick Sort");
            int[] myArray = { 4, 8, 3, 1, 10, 6, 2, 3 };
            QuickSort qs = new QuickSort();
            qs.Sort(myArray);
            PrintArray(myArray);
            Console.WriteLine();

            Console.WriteLine("Merge Sort");
            int[] arr3 = { 12, 11, 13, 5, 6, 7 };
            MergeSort ms = new MergeSort();
            ms.Sort(arr3);
            PrintArray(arr3);
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
