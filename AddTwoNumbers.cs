/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    // Adds two numbers stored in liniked lists in reverse order
    // Returns a linked list representing the sum
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // As digits are stored in reverse order, we can traverse through the lists,
        // add digits and generate carries
        // EDGE CASES TO CONSIDER
        // 1. One list is null and one list isn't
        // 2. Both lists are null

        ListNode head = new ListNode(0);
        ListNode currentNode = head;
        int carryOver = 0;
        while (l1 != null || l2 != null || carryOver != 0) {
            // Determine currentNode value and carryOver
            int sum = ((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0) + carryOver;
            currentNode.next = new ListNode(sum % 10);
            currentNode = currentNode.next;
            carryOver = (sum >= 10) ? 1 : 0;

            // Traverse linked lists
            l1 = (l1 != null) ? l1.next : l1;
            l2 = (l2 != null) ? l2.next : l2;
        }

        return head.next;
    }
}
