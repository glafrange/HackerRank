static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
    if (position == 0)
    {
        return head.next;
    }
    
    SinglyLinkedListNode currentNode = head;
    
    for (int index = 0; index < position - 1; index++)
    {
        if (currentNode.next != null)
        {
            currentNode = currentNode.next;
        }
    }
    
    currentNode.next = currentNode.next.next;
    
    return head;
}