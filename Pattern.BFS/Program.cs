﻿using System;
using System.Collections.Generic;

namespace Pattern.BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(12);
            //root.Left = new TreeNode(7);
            //root.Right = new TreeNode(1);
            //root.Left.Left = new TreeNode(9);
            //root.Right.Left = new TreeNode(10);
            //root.Right.Right = new TreeNode(5);
            //List<List<int>> result = LevelOrderTraversal.Traverse(root);
            //Console.WriteLine("Level order traversal");
            //foreach (var item in result)
            //{
            //    foreach (var el in item)
            //    {
            //        Console.Write(el + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //result = ReverseLevelOrderTraversal.Traverse(root);
            //Console.WriteLine("Reverse level order traversal");
            //foreach (var item in result)
            //{
            //    foreach (var el in item)
            //    {
            //        Console.Write(el + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //result = ZigzagTraversal.Traverse(root);
            //Console.WriteLine("Zigzag traversal");
            //foreach (var item in result)
            //{
            //    foreach (var el in item)
            //    {
            //        Console.Write(el + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //var root2 = new TreeNode(12);
            //root2.Left = new TreeNode(7);
            //root2.Right = new TreeNode(1);
            //root2.Left.Left = new TreeNode(9);
            //root2.Left.Right = new TreeNode(2);
            //root2.Right.Left = new TreeNode(10);
            //root2.Right.Right = new TreeNode(5);
            //var result2 =  LevelAverages.FindAverages(root2);
            //Console.WriteLine("Level Averages");
            //foreach (var item in result2)
            //{                
            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine();

            TreeNode root = new TreeNode(12);
            root.Left = new TreeNode(7);
            root.Right = new TreeNode(1);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);
            Console.WriteLine("Tree Minimum Depth: " + MinimumBinaryTreeDepth.FindDepth(root));
            root.Left.Left = new TreeNode(9);
            root.Right.Left.Left = new TreeNode(11);
            Console.WriteLine("Tree Minimum Depth: " + MinimumBinaryTreeDepth.FindDepth(root));
            Console.WriteLine();


        }
    }
}
