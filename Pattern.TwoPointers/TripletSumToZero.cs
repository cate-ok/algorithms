using System;
using System.Collections.Generic;

namespace Pattern.TwoPointers
{
    //
    // Given an array of unsorted numbers, find all unique triplets in it that add up to zero
    //
    public class TripletSumToZero
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

/*
   public static List<List<Integer>> searchTriplets(int[] arr) {
    Arrays.sort(arr);
    List<List<Integer>> triplets = new ArrayList<>();
    for (int i = 0; i < arr.length - 2; i++) {
      if (i > 0 && arr[i] == arr[i - 1]) // skip same element to avoid duplicate triplets
        continue;
      searchPair(arr, -arr[i], i + 1, triplets);
    }

    return triplets;
  }

  private static void searchPair(int[] arr, int targetSum, int left, List<List<Integer>> triplets) {
    int right = arr.length - 1;
    while (left < right) {
      int currentSum = arr[left] + arr[right];
      if (currentSum == targetSum) { // found the triplet
        triplets.add(Arrays.asList(-targetSum, arr[left], arr[right]));
        left++;
        right--;
        while (left < right && arr[left] == arr[left - 1])
          left++; // skip same element to avoid duplicate triplets
        while (left < right && arr[right] == arr[right + 1])
          right--; // skip same element to avoid duplicate triplets
      } else if (targetSum > currentSum)
        left++; // we need a pair with a bigger sum
      else
        right--; // we need a pair with a smaller sum
    }
  }
 */
