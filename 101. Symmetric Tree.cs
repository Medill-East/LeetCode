/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root.left == null && root.right == null)
        {
            return true;
        }
        else
        {
            return (IsLeftEqualsRight(root.left,root.right));
        }
    }

    private bool IsLeftEqualsRight(TreeNode left, TreeNode right)
    {
        if((left.val == right.val) && (IsLeftEqualsRight(left.left,right.right)) && (IsLeftEqualsRight(left.right,right.left)))
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}