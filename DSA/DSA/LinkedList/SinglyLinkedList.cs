namespace DSA.LinkedList
{
    public class SinglyLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            if(head.next == null)
                return head;

            Stack<ListNode> stack = new Stack<ListNode>();


            while (head.next != null)
            {
                stack.Push(head);
                head = head.next;
            }

            
            ListNode newHead = stack.Pop();
            ListNode next;

            newHead.next = ;

            for (int i = 0; i < stack.Count; i++)
            {
                ListNode newNode = stack.Pop();
                newHead.next = newNode;

            }
            



            return newHead;
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
