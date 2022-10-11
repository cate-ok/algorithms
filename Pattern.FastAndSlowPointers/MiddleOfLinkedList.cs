using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FastAndSlowPointers
{
    class MiddleOfLinkedList
    {
        // Time O(N), Space O(1)
        public static ListNode FindMiddle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
}
