using System;

namespace Algorithms.DataStructures.LinkedList
{
    public class Node
    {
        public int data;
        public Node prev = null;
        public Node next = null;

        public Node(int d)
        {
            data = d;
        }
    }
}