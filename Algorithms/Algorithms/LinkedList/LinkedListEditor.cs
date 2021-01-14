using System.Collections.Generic;
using Algorithms.DataStructures.LinkedList;

namespace Algorithms.Algorithms.LinkedList
{
    public class LinkedListEditor
    {
        public Node CreateLinkedList(int[] d)
        {
            Node head = new Node(d[0]);
            var n = head;
            for (var i = 1; i < d.Length; i++)
            {
                n.next = new Node(d[i]);
                n = n.next;
            }
            return head;
        }

        public int[] ToArray(Node head)
        {
            List<int> lst = new List<int>();
            var n = head;
            while (n.next != null)
            {
                lst.Add(n.next.data);
                n = n.next;
            }
            return lst.ToArray();
        }

        public void RemoveDups(Node head)        // O(N) time
        {
            HashSet<int> set = new HashSet<int>();
            var n = head;
            while (n.next != null)
            {
                if (set.Contains(n.next.data))
                {
                    if (n.next.next != null)
                        n.next = n.next.next;
                }
                else
                {
                    set.Add(n.next.data);
                }
                n = n.next;
            }
        }

        public void RemoveDups2(Node head)        // O(1) space, O(n^2) time
        {            
            var n1 = head;
            var n2 = head;
            while (n1.next != null)
            {
                while (n2.next != null)
                {
                    if (n1.data == n2.next.data)
                    {
                        if (n2.next.next == null)
                        {
                            n2.next = null;
                            break;
                        }
                        else
                        {
                            n2.next = n2.next.next;
                        }
                    }
                    n2 = n2.next;
                }
                n1 = n1.next;
                n2 = n1;
            }
        }
    }
}
