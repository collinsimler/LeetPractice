namespace DSA.LinkedList
{
    public static class SinglyLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            if(head.next == null)
                return head;

            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                var nxt = current.next;
                current.next = prev;
                prev = current;
                current = nxt;
                
            }

            return prev;
        }

    }


    // Definition for ListNode list.
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
