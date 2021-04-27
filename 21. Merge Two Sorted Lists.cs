
  //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution21 {
    //202002170036
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode current = result;
        while (l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                current.next = l1;
                current = current.next;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                current = current.next;
                l2 = l2.next;
            }
        }

        if(l1 == null)
        {
            current.next = l2;
        }
        else
        {
            current.next = l1;
        }
        
        return result.next;
    }
}