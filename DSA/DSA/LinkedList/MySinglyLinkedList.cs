public class MySinglyLinkedList {

    private ListNode _head;
    private ListNode? _tail;    

    public MySinglyLinkedList() {
        _head = new ListNode();
        _tail = null;
    }
    
    public int Get(int index) {
        if(_head == null){
            return -1;
        }

        ListNode curr = _head;
        for(int i = 0; i <= index; i++){
            if(i == index && curr != null){
                return curr.val;
            }else if(curr != null){
                curr = curr.next;
            }else{
                return -1;
            }
        }

        return -1;
       
    }
    
    public void AddAtHead(int val) {
        ListNode newNode = new ListNode(val, _head);
        _head = newNode;
    }
    
    public void AddAtTail(int val) {
        ListNode newNode = new ListNode(val);
        _tail.next = newNode;
        _tail = newNode;
    }
    
    public void AddAtIndex(int index, int val) {
        
        ListNode curr = _head;
        
        int currentIndex = 0;
        while(curr != null){
            if(currentIndex == index){
                
            }else{
                curr = curr.next;
            }

            currentIndex++;
        }

    }
    
    public void DeleteAtIndex(int index) {
        
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