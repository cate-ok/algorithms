using Algorithms.DataStructures.Tree;
using System;

namespace Algorithms.Algorithms.Tree
{
    public class BinaryTreeBuilder
    {
        public BinaryTreeNode<int> MinimalTree(int[] nums)
        {
            return BuildTree(nums, 0, nums.Length-1);
        }

        BinaryTreeNode<int> BuildTree(int[] nums, int start, int end)
        {
            Console.WriteLine("start: " + start.ToString());
            Console.WriteLine("end: " + end.ToString());
            if (end < start)
                return null;
            var center = (end + start) / 2;
            Console.WriteLine("center: " + center.ToString());
            BinaryTreeNode<int> n = new BinaryTreeNode<int>(nums[center]);
            if (center > 0)
            {
                n.left = BuildTree(nums, start, center-1);
                n.right = BuildTree(nums, center+1, end);
            }
            return n;
        }
    }
}