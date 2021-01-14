using System;

namespace Algorithms.DataStructures.Stack
{
    public class StackNode<T>
    {
        public T data;
        public StackNode<T> prev;

        public StackNode(T d)
        {
            data = d;
        }
    }
}
