using System;

/*
 Given an array of sorted numbers, remove all duplicate number instances from it in-place, such that each element appears only once. The relative order of the elements should be kept the same and you should not use any extra space so that that the solution have a space complexity of O(1).

Move all the unique elements at the beginning of the array and after moving return the length of the subarray that has no duplicate in it.
 */
namespace Pattern.TwoPointers
{
    class RemoveDuplicates
    {
        // Time O(N), Space O(1)
        public static int Remove(int[] arr)
        {
            if (arr.Length < 2)
                return 1;

            int p1 = 0;
            int p2 = 1;

            while(p2 < arr.Length)    // can use for loop
            {
                if (arr[p1] == arr[p2])
                {
                    p2++;
                }
                else
                {
                    p1++;
                    arr[p1] = arr[p2];
                }
            }
            return p1+1;
        }
    }
}
