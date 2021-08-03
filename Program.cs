using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode l1 = new ListNode(9);
            l1.next = new ListNode(9);
            l1.next.next= new ListNode(9);
           
            ListNode l2 = new ListNode(9);
            l2.next = new ListNode(9);
            ListNode answer = solution.AddTwoNumbers(l1, l2);

            while (answer.next != null)
            {
                Console.WriteLine(answer.val);
                
            }
            
            


           

        }



        
    }

    public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum= 0;
        ListNode answer = new ListNode();
        ListNode result = answer;

            while (l1 != null || l2 != null)
            {
                 
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                answer.next = new ListNode(sum % 10);
                sum /= 10;

                answer = answer.next;

            }

            if(sum > 0){
                answer.next = new ListNode(sum % 10);
            }

        return result.next;
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
