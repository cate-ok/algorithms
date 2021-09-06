using System;

namespace DataStructures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private QueueNode<T> first;
        private QueueNode<T> last;

        public void Add(T data)
        {
            QueueNode<T> n = new QueueNode<T>(data);
            if (first == null)
            {
                first = n;
                last = n;
            }            
            else
            {
                last.prev = n;
                last = n;
            }            
        }

        public T Remove()
        {
            if (first == null) throw new InvalidOperationException("Sequence contains no elements");

            var data = first.data;
            first = first.prev;
            if (first == null)
                last = null;            
            return data;
        }

        public T Peek()
        {
            if (first == null) throw new InvalidOperationException("Sequence contains no elements");
            return first.data;
        }

        public bool IsEmpty()
        {
            return (first == null);
        }
    }
}