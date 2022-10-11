using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FastAndSlowPointers
{
    class LinkedListCycle
    {
        // Time O(N) Space O(1)
        public static bool HasCycle(ListNode head)
        {
            ListNode p1 = head;
            ListNode p2 = head.next;
            while(p2 != null && p2.next!= null)
            {
                if (p1 == p2)
                    return true;
                p1 = p1.next;
                p2 = p2.next.next;
            }
            return false;
        }

        public static int FindCycleLength(ListNode head)
        {            
            ListNode p1 = head;
            ListNode p2 = head.next;
            while (p2.next != null)
            {
                if (p1 == p2)
                {
                    int cycleLength = 0;
                    do
                    {
                        p1 = p1.next;
                        cycleLength++;
                    }
                    while (p1 != p2);
                    return cycleLength;
                }                
                p1 = p1.next;
                p2 = p2.next.next;
            }
            return 0;
        }
    }
}
