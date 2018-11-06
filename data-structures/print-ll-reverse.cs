static void reversePrint(SinglyLinkedListNode head) {
    if (head.next != null)
    {
        reversePrint(head.next);
    }
    
    Console.WriteLine(head.data);
}