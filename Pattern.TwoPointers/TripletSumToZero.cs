using System;
using System.Collections.Generic;

namespace Pattern.TwoPointers
{
    //
    // Given an array of unsorted numbers, find all unique triplets in it that add up to zero
    //
    class TripletSumToZero
    {
        public static List<List<int>> SearchTriplets(int[] arr)
        {
            if (arr.Length < 3)
                return null;

            Array.Sort(arr);
            List<List<int>> triplets = new List<List<int>>();
            int x = 0;
            int y = arr.Length - 1;
            int sum;

            for(int i=1; i<arr.Length-1; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;
                while (x < i && y > i)
                {
                    sum = arr[x] + arr[y] + arr[i];
                    if (sum == 0)
                    {
                        triplets.Add(new List<int> { arr[x], arr[i], arr[y] });
                        x++;
                        y--;
                    }
                    else if(sum > 0)
                    {
                        y--;
                    }
                    else
                    {
                        x++;
                    }
                }
            }
            return triplets;
        }
    }
}
