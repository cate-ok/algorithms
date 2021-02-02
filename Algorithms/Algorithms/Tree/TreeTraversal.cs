using System;
using Algorithms.DataStructures.Tree;

namespace Algorithms.Algorithms.Tree
{
    public class TreeTraversal<T>
    {
        void PrintNodeName(BinaryTreeNode<T> n)
        {
            Console.WriteLine(n.name);
        }

        public void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node!= null) {                
                InOrderTraversal(node.left);
                PrintNodeName(node);
                InOrderTraversal(node.right);
            }
        }

        public void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PrintNodeName(node);
                InOrderTraversal(node.left);                
                InOrderTraversal(node.right);
            }
        }

        public void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.left);
                InOrderTraversal(node.right);
                PrintNodeName(node);
            }
        }
    }
}
