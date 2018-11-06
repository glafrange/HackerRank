static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
    SinglyLinkedListNode currentNode = head;
    
    for (int index = 0; index < position - 1; index++)
    {
        if (currentNode.next != null)
        {
            currentNode = currentNode.next;
        }
    }
    
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    
    newNode.next = currentNode.next;
    currentNode.next = newNode;
    
    return head;
}