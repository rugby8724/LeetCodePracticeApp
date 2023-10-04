using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class MergeTwoLinkedList
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            ListNode sortedHead;
            ListNode sorted;

            if (list1 == null || list2 == null)
            {
                if (list1 == null && list2 == null)
                {
                    return sorted = null;
                }
                else if (list1 == null)
                {
                    return sorted = list2;
                }
                else { return sorted = list1; }
            }
            if (list1.val <= list2.val)
            {
                sortedHead = list1;
                sorted = list1;
                list1 = list1.next;
            }
            else
            {
                sortedHead = list2;
                sorted = list2;
                list2 = list2.next;
            }

            while (list1 != null || list2 != null)
            {
                if(list1 == null || list2.val <= list1.val)
                {
                    sorted.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    sorted.next = list1;
                    list1 = list1.next;
                }
            }

            return sorted;

            
        }
    }
}
