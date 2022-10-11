using System;

namespace Pattern.LinkedListReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(2);
            head.next = new ListNode(4);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(8);
            head.next.next.next.next = new ListNode(10);

            ListNode result = ReverseLinkedList.Reverse(head);
            Console.WriteLine("Nodes of the reversed LinkedList are: ");
            while (result != null)
            {
                Console.WriteLine(result.value + " ");
                result = result.next;
            }
        }
    }
}
