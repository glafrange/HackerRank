static SinglyLinkedListNode reverse(SinglyLinkedListNode head) {
    SinglyLinkedListNode next = head;
    if (head.next != null)
    {
        SinglyLinkedListNode originalHead = head;
        next = head.next;
        head.next = null;
        head = next;
        if (head.next != null)
        {
            next = head.next;
            head.next = originalHead;
        }
    }
    
    while(next != null)
    {
        SinglyLinkedListNode currentNode = next;
        next = currentNode.next;
        currentNode.next = head;
        head = currentNode;
    }
    
    
    return head;
}