using System;

namespace Algorithms.DataStructures.LinkedList
{
    public class LinkedList
    {
        public Node head;

        public void AppendToTail(int d)
        {            
            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node(d);
            current.next = newNode;
        }

        public void DeleteNode(int d)
        {
            var current = head;
            if (current.data == d)
            {
                head = current.next; // move head
                return;
            }
            while (current.next != null)
            {                
                if (current.next.data == d)
                {
                    current.next = current.next.next;   // move reference to next element
                }
                current = current.next;
            }
        }
    }
}