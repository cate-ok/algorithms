using System;
using Algorithms.DataStructures.Queue;
using Algorithms.DataStructures.Stack;

namespace Algorithms.Algorithms.Queue
{
    public class MyQueue<T> : IQueue<T>
    {
        Stack<T> a;
        Stack<T> b;

        public MyQueue()
        {
            a = new Stack<T>();
            b = new Stack<T>();
        }

        public void Add(T data)
        {
            T t;
            if (!b.IsEmpty())
            {
                // from b to a
                while (!b.IsEmpty())
                {
                    t = b.Pop();
                    a.Push(t);
                }
            }
            a.Push(data);
            // from a to b
            while (!a.IsEmpty())
            {
                t = a.Pop();
                b.Push(t);
            }
        }

        public bool IsEmpty()
        {
            return a.IsEmpty() && b.IsEmpty();
        }

        public T Peek()
        {
            return b.Peek();
        }

        public T Remove()
        {
            return b.Pop();
        }
    }
}
