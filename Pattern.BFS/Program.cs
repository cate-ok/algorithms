using System;
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

            //TreeNode root = new TreeNode(12);
            //root.Left = new TreeNode(7);
            //root.Right = new TreeNode(1);
            //root.Right.Left = new TreeNode(10);
            //root.Right.Right = new TreeNode(5);
            //Console.WriteLine("Tree Minimum Depth: " + MinimumBinaryTreeDepth.FindDepth(root));
            //root.Left.Left = new TreeNode(9);
            //root.Right.Left.Left = new TreeNode(11);
            //Console.WriteLine("Tree Minimum Depth: " + MinimumBinaryTreeDepth.FindDepth(root));
            //Console.WriteLine();



            //TreeNode root = new TreeNode(1);
            //root.Left = new TreeNode(2);
            //root.Right = new TreeNode(3);
            //root.Left.Left = new TreeNode(4);
            //root.Left.Right = new TreeNode(5);

            //TreeNode result = LevelOrderSuccessor.FindSuccessor(root, 3);
            //if (result != null)
            //    Console.WriteLine(result.Value + " ");

            //root = new TreeNode(12);
            //root.Left = new TreeNode(7);
            //root.Right = new TreeNode(1);
            //root.Left.Left = new TreeNode(9);
            //root.Right.Left = new TreeNode(10);
            //root.Right.Right = new TreeNode(5);

            //result = LevelOrderSuccessor.FindSuccessor(root, 9);
            //if (result != null)
            //    Console.WriteLine(result.Value + " ");

            //result = LevelOrderSuccessor.FindSuccessor(root, 12);
            //if (result != null)
            //    Console.WriteLine(result.Value + " ");


            //TreeNodeLinked root = new TreeNodeLinked(12);
            //root.Left = new TreeNodeLinked(7);
            //root.Right = new TreeNodeLinked(1);
            //root.Left.Left = new TreeNodeLinked(9);
            //root.Right.Left = new TreeNodeLinked(10);
            //root.Right.Right = new TreeNodeLinked(5);
            //ConnectLevelOrderSiblings.Connect(root);
            //Console.WriteLine("Level order traversal using 'next' pointer: ");
            //ConnectLevelOrderSiblings.PrintLevelOrder(root);


            TreeNode root = new TreeNode(12);
            root.Left = new TreeNode(7);
            root.Right = new TreeNode(1);
            root.Left.Left = new TreeNode(9);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);
            ConnectAllSiblings.Connect(root);

            // level order traversal using 'next' pointer
            TreeNode current = root;
            Console.WriteLine("Traversal using 'next' pointer: ");
            while (current != null)
            {
                Console.WriteLine(current.val + " ");
                current = current.next;
            }


        }
    }
}
