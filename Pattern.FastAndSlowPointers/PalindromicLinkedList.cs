using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FastAndSlowPointers
{
    class PalindromicLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            ListNode middleNode = MiddleOfLinkedList.FindMiddle(head);

            ListNode first = head;
            ListNode last = head;
            while (last.next != null)
            {
                last = last.next;
            }            
            while (first.value == last.value)
            {
                if (last == middleNode)
                    return true;
                first = first.next;
                ListNode temp = last;
                last = first;
                while (last.next != temp)
                    last = last.next;
            }
            return false;
        }
    }
}
