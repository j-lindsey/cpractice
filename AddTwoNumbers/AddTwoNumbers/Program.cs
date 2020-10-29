using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
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
    class Program
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(-1);
            ListNode result2 = result;

            int carry = 0, remainder = 0, temp = 0;

            while (l1 != null && l2 != null)
            {
                temp = l1.val + l2.val + carry;
                carry = temp / 10;
                remainder = temp % 10;

                result2.next = new ListNode(remainder);
                l1 = l1.next;
                l2 = l2.next;
                result2 = result2.next;
            }

            ListNode remain = l1 != null ? l1 : l2;

            while (remain != null)
            {
                temp = remain.val + carry;
                carry = temp / 10;
                remainder = temp % 10;
                result2.next = new ListNode(remainder);
                result2 = result2.next;

                if (carry == 0)
                {
                    result2.next = remain.next;
                    break;
                }

                remain = remain.next;
            }

            if (carry == 1)
            {
                result2.next = new ListNode(1);
            }

            return result.next;
        }
        static void Main(string[] args)
        {
            
        }
    
}
