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
    // Method merges two trees by placing them on top of each other and summing nodes
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) {
            return null;
        }
        else if (t2 == null) {
            // Depending on if the original tree will still be used
            // we need to consider that the modified tree will reference
            // nodes from t1/t2
            return t1;
        }
        else if (t1 == null) {
            return t2;
        }
        else {
            // t1 and t2 are not null
            TreeNode newTree = new TreeNode(t1.val + t2.val);
            // Merge left and right subtrees
            newTree.left = MergeTrees(t1.left, t2.left);
            newTree.right = MergeTrees(t1.right, t2.right);
            return newTree;
        }
    }
}
