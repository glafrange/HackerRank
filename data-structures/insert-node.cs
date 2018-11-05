static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) {
    if (head == null)
    {
        head = new SinglyLinkedListNode(data);
        return head;
    }
    
    SinglyLinkedListNode tail = head;
    while (tail.next != null)
    {
        tail = tail.next;
    }
    
    tail.next = new SinglyLinkedListNode(data);
    return head;
}