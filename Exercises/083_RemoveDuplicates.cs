// https://leetcode.com/problems/remove-duplicates-from-sorted-list/

namespace LeetCode
{

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class RemoveDuplicates
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if(head == null || head.next == null){
                return head;
            }
            head.next = DeleteDuplicates(head.next);
            return head.val == head.next.val ? head.next : head;
        }
    }
}