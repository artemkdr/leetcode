/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        List<int> n1 = new List<int>();
        List<int> n2 = new List<int>();        
        var next1 = l1;
        var next2 = l2;
        ListNode l3 = null;
        var next3 = l3;
        int rest = 0, i = 0, j1 = 0, j2 = 0, j3 = 0;  

        while (next1 != null || next2 != null) {
            if (next1 != null) {            
                n1.Add(next1.val);
                next1 = next1.next;
            }
            if (next2 != null) {            
                n2.Add(next2.val);
                next2 = next2.next;                
            }

            j1 = i < n1.Count ? n1[i] : 0;
            j2 = i < n2.Count ? n2[i] : 0;
            j3 = j1 + j2 + rest;
            if (j3 >= 10) {
                rest = 1;
                j3 = j3 - 10;
            } else {
                rest = 0;
            }
            if (l3 == null) {
                l3 = new ListNode(j3, null);
                next3 = l3;
            } else {
                next3.next = new ListNode(j3, null);
                next3 = next3.next; 
            }  
            i++;            
        }                
        if (rest > 0)
            next3.next = new ListNode(rest, null);   
        return l3;
    }
}