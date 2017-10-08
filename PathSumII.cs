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
    // Given a binary tree and a sum method returns all root-to-leaf paths where each path's sum equals the given sum
    public List<List<int>> PathSum(TreeNode root, int sum) {
        // List of interger lists to store the result
        List<List<int>> results = new List<List<int>>();

        // Edge case - root is null
        if (root == null) {
            return results;
        }

        List<int> list = new List<int>();
        onePathSum(root, sum, 0, list, results);
        return results;
    }

    // Method to generate the lists while we traverse the tree
    // This method can be performed in O(n) assuming creating and coping newLists can be done in O(1)
    // This method may not be the most effecient way to solve the problem in terms of space
    public void onePathSum(TreeNode root, int requiredSum, int currentSum, List<int> currentList, List<List<int>> currentLists) {
        List<int> newList = new List<int>(currentList);

        // Add currentNode to the list
        newList.Add(root.val);

        // Base cases
        if (root.left == null && root.right == null) {
            if (currentSum + root.val == requiredSum) {
                currentLists.Add(newList);
            }
        }

        if (root.left != null) {
            // We can move down the left
            onePathSum(root.left, requiredSum, currentSum + root.val, newList, currentLists);
        }

        if (root.right != null) {
            // We can move down the right
            onePathSum(root.right, requiredSum, currentSum + root.val, newList, currentLists);
        }

        return;
    }
}
