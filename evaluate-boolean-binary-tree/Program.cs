using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool EvaluateTree(TreeNode root)
    {
        if (root == null)
        {
            throw new ArgumentNullException(nameof(root));
        }

        return Evaluate(root);
    }

    private bool Evaluate(TreeNode node)
    {
        // If the node is a leaf node, return its boolean value.
        if (node.left == null && node.right == null)
        {
            return node.val == 1;
        }

        // Recursively evaluate the left and right subtrees.
        bool leftVal = Evaluate(node.left);
        bool rightVal = Evaluate(node.right);

        // Apply the operation based on the node's value.
        if (node.val == 2) // OR operation
        {
            return leftVal || rightVal;
        }
        else if (node.val == 3) // AND operation
        {
            return leftVal && rightVal;
        }
        else
        {
            throw new InvalidOperationException("Invalid node value for a non-leaf node.");
        }
    }
}
