﻿using System;

namespace Algorithms.DataStructures.Queue
{
    public interface IQueue<T>
    {
        public void Add(T data);

        public T Remove();

        public T Peek();

        public bool IsEmpty();        
    }
}