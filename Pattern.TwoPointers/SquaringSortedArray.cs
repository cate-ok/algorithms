using System;

namespace Pattern.TwoPointers
{
    class SquaringSortedArray
    {
        // Time and spece - O(N)
        public static int[] MakeSquares(int[] arr)
        {
            int len = arr.Length;
            int[] result = new int[len];
            int p1 = 0;
            int p2 = len - 1;
            int insertIndex = len - 1;

            while (p1 < p2)
            {
                if(Math.Abs(arr[p1]) > Math.Abs(arr[p2]))
                {
                    result[insertIndex] = arr[p1] * arr[p1];
                    p1++;
                }
                else
                {
                    result[insertIndex] = arr[p2] * arr[p2];
                    p2--;
                }
                insertIndex--;
            }
            return result;
        }
    }
}
