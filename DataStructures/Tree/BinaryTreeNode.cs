using System;

namespace DataStructures.Tree
{
    public class BinaryTreeNode<T>
    {
        public T name;
        public BinaryTreeNode<T> left;
        public BinaryTreeNode<T> right;

        public BinaryTreeNode(T n)
        {
            name = n;
        }
    }
}
