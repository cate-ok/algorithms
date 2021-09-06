using Algorithms.Algorithms.Tree;
using DataStructures.Tree;
using System;

namespace PracticeApp.Trees
{
    public class TreeTraversalExample
    {
        public void InOrderTraversalTest()
        {
            var root = new BinaryTreeNode<int>(10);
            var n1 = new BinaryTreeNode<int>(5);
            n1.left = new BinaryTreeNode<int>(3);
            n1.right = new BinaryTreeNode<int>(7);
            root.left = n1;
            var n2 = new BinaryTreeNode<int>(20);
            n1.left = new BinaryTreeNode<int>(15);
            root.right = n2;

            TreeTraversal<int> treeTraversal = new TreeTraversal<int>();
            var callback = new ProcessNode<int>(PrintNodeName);
            treeTraversal.InOrderTraversal(root, callback);            
        }

        void PrintNodeName(BinaryTreeNode<int> n)
        {
            Console.WriteLine(n.name);
        }
    }
}
