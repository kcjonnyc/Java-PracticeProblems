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
    // Determines if a binary tree is height-balanced
    // The depth of the two subtrees of every node cannot differ by more than 1
    // This algorithm has a runtime of O(n^2)
    public bool IsBalanced(TreeNode root) {
        if (root == null) {
            return true;
        }
        else if (Math.Abs(BSTMaxHeight(root.left) - BSTMaxHeight(root.right)) > 1){
            return false;
        }

        // The root is balanced, traverse the tree and ensure subtrees are balanced
        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    // Max height can be determined in O(n)
    // The depth of every node is the max height
    public int BSTMaxHeight(TreeNode root) {
        // Base case for null root and leaves
        if (root == null) {
            return -1;
        }
        else if (root.left == null && root.right == null) {
            return 0;
        }

        // Determine max height of subtrees and add height of 1
        return 1 + Math.Max(BSTMaxHeight(root.left), BSTMaxHeight(root.right));
    }
}
