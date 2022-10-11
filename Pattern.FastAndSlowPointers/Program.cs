using System;

namespace Pattern.FastAndSlowPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next = new ListNode(6);
            //Console.WriteLine("LinkedList has cycle: " + LinkedListCycle.HasCycle(head));

            //head.next.next.next.next.next.next = head.next.next;
            //Console.WriteLine("LinkedList has cycle: " + LinkedListCycle.HasCycle(head));
            //Console.WriteLine("Cycle length: " + LinkedListCycle.FindCycleLength(head));

            //Console.WriteLine("LinkedList cycle start: " + LinkedListCycleStart.FindCycleStart(head).value);

            //head.next.next.next.next.next.next = head.next.next.next;
            //Console.WriteLine("LinkedList has cycle: " + LinkedListCycle.HasCycle(head));

            //Console.WriteLine("Happy number: " + HappyNumber.Find(23));
            //Console.WriteLine("Happy number: " + HappyNumber.Find(12));


            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //Console.WriteLine("Middle Node: " + MiddleOfLinkedList.FindMiddle(head).value);
            //head.next.next.next.next.next = new ListNode(6);
            //Console.WriteLine("Middle Node: " + MiddleOfLinkedList.FindMiddle(head).value);
            //head.next.next.next.next.next.next = new ListNode(7);
            //Console.WriteLine("Middle Node: " + MiddleOfLinkedList.FindMiddle(head).value);


            ListNode head = new ListNode(2);
            head.next = new ListNode(4);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(2);
            Console.WriteLine("Is palindrome: " + PalindromicLinkedList.IsPalindrome(head)); // true

            head.next.next.next.next.next = new ListNode(2);
            Console.WriteLine("Is palindrome: " + PalindromicLinkedList.IsPalindrome(head)); // false
        }
    }
}
