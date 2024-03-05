/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    
    public bool HasCycle(ListNode head) {  
        if (head == null || head.next == null) return false;
        ListNode next = head, afterNext = head.next;        
        while (afterNext != null && afterNext.next != null) {            
            //Console.WriteLine("next = " + next.val + ", afterNext = " + afterNext.val);
            next = next.next;
            afterNext = afterNext.next.next;
            if (next == afterNext) return true;            
        }
        return false;
    }
}