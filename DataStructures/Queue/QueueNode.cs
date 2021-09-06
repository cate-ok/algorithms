using System;

namespace DataStructures.Queue
{
    public class QueueNode<T>
    {
        public T data;
        public QueueNode<T> prev;

        public QueueNode(T d)
        {
            data = d;
        }
    }
}