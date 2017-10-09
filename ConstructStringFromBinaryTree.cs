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
    // Method to construct a string which consists of parenthesis and integers
    // from a binary tree with the preorder traversing way
    public string Tree2str(TreeNode t) {
        // We are using a preorder traversal
        // We add parenthesis to indicate the left and right subtrees
        // A () is also needed to represent nulls, but this is only needed
        // when the left subtree is null as a placeholder

        // Base cases
        if (t == null) {
            return string.Empty;
        }
        else if (t.left == null && t.right == null) {
            return string.Empty + t.val;
        }
        else if (t.left == null) {
            // The case where we need the placeholder parenthesis
            return t.val + "()(" + Tree2str(t.right) + ")";
        }
        else if (t.right == null) {
            return t.val + "(" + Tree2str(t.left) + ")";
        }
        else {
            return t.val + "(" + Tree2str(t.left) + ")(" + Tree2str(t.right) + ")";
        }
    }
}
