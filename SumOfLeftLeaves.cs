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
    // Method sums all the left leaves in a binary tree
    public int SumOfLeftLeaves(TreeNode root) {
        // We want to traverse the entire tree but only add the left leaves
        if (root == null || (root.left == null && root.right == null)) {
            // Base cases for null root or just a root
            return 0;
        }
        else if (root.left != null && root.left.left == null && root.left.right == null) {
            // Consider the case where we have a leaf
            // Add the value at the leaf with the sum of the left leaves of the right subtree
            return root.left.val + SumOfLeftLeaves(root.right);
        }

        return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
    }
}
