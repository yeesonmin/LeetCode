using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();

            Console.WriteLine(l1.val);

            l1.next = new ListNode(1);
            Console.WriteLine(l1.val);

            l1 = l1.next;
            Console.WriteLine(l1.val);


        }

        
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
