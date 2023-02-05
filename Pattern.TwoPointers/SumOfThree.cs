using System;

namespace Pattern.TwoPointers
{
    // Given an array of integers, nums, and an integer value, target, determine if there are any three integers in nums whose sum equals the target. Return TRUE if three such integers are found in the array. Otherwise, return FALSE.
    public class SumOfThree
    {
        // Time complexity O(n^2), space - O(1) because we only use the space needed to store two index values
        public static bool FindSumOfThree(int[] nums, int target)
        {            
            int low, high;
            Array.Sort(nums);
            for (var i=0; i < nums.Length-2; i++)
            {
                low = i + 1;
                high = nums.Length-1;
                while (high > low)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum == target)
                    {
                        return true;
                    }
                    else if (sum < target)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }
            return false;
        }
    }
}
