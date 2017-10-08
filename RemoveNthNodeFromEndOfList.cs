/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 
public class Solution {
    // Given a linked list, method remove the nth node from the end of list and return its head
    // Where the last node in the linked list is n = 1
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // Try to perform this operation in one pass
        // We need a pointer for the currentNode and beforeNodeToRemove
        ListNode currentNode = head;
        ListNode beforeNodeToRemove = head;

        // Move through the linkedList
        // currentNode will be n nodes away from beforeNodeToRemove
        for (int count = 0; count < n; count++) {
            currentNode = currentNode.next;
        }

        if (currentNode == null) {
            return head.next;
        }

        currentNode = currentNode.next;
        // Now beforeNodeToRemove is the correct distance away
        // both currentNode and beforeNodeToRemove move together
        while (currentNode != null) {
            currentNode = currentNode.next;
            beforeNodeToRemove = beforeNodeToRemove.next;
        }

        beforeNodeToRemove.next = beforeNodeToRemove.next.next;
        return head;
    }
}
