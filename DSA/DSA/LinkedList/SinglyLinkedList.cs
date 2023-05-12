namespace DSA.LinkedList
{
    public class SinglyLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode previousNode = null, curr = head;


            while (curr != null)
            {
                //save current info
                var nextNode = curr.next;

                //make the reversal
                curr.next = previousNode;
                previousNode = curr;
                curr = nextNode;

            }



            return previousNode;

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
