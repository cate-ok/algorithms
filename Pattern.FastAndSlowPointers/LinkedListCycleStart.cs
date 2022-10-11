using System;

namespace Pattern.FastAndSlowPointers
{
    class LinkedListCycleStart
    {
        // Time O(N) Space O(1)
        public static ListNode FindCycleStart(ListNode head)
        {
            int cycleLength = LinkedListCycle.FindCycleLength(head);
            ListNode pointer1 = head;
            ListNode pointer2 = head;
            for(var i=0; i<cycleLength; i++)
            {
                pointer2 = pointer2.next;
            }
            while (pointer1 != pointer2)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }
            return pointer1;
        }
    }
}
