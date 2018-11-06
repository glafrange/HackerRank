static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
    while (head1.next != null && head2.next != null)
    {
        if(head1.data != head2.data)
        {
            return false;
        }
        
        head1 = head1.next;
        head2 = head2.next;
    }
    if (head1.data != head2.data || head1.next != head2.next)
    {
        return false;
    }
    
    return true;
}