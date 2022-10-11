using System;

namespace Pattern.LinkedListReversal
{
    class ReverseLinkedList
    {
        // Time O(N), Space O(1)
        public static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode temp = null;
            ListNode current = head;

            while(current.next!= null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            current.next = prev;
            return current;
        }
    }
}
