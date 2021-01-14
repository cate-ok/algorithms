using System;

namespace Algorithms.DataStructures.Stack
{
    public class Stack <T>
    {
        StackNode<T> top;

        public void Push(T data)
        {
            StackNode<T> n = new StackNode<T>(data);
            n.prev = top;
            top = n;
        }

        public T Pop()
        {
            if(top == null) throw new InvalidOperationException("Stack is empty");
            var t = top.data;
            top = top.prev;
            return t;
        }

        public T Peek()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty");
            return top.data;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }
    }
}
