using Common;
using System;

class Program
{
    private static bool isBalanced = true;

    static void Main()
    {
        var root = new TreeNode(1);
        Console.WriteLine(IsBalanced(root));
    }

    public static bool IsBalanced(TreeNode root)
    {
        IsBalancedRecursive(root);
        return isBalanced;
    }

    private static int IsBalancedRecursive(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int left = IsBalancedRecursive(node.left) + 1;
        int right = IsBalancedRecursive(node.right) + 1;
        if (Math.Abs(left - right) > 1)
        {
            isBalanced = false;
        }

        return Math.Max(left, right);
    }

    private static int IsBalancedRecursive(TreeNode root, int currentDepth)
    {
        if (root == null || isBalanced == false)
        {
            return currentDepth;
        }

        var leftDepth = IsBalancedRecursive(root.left, currentDepth + 1);
        var rightDepth = IsBalancedRecursive(root.right, currentDepth + 1);
        var distance = Math.Abs(leftDepth - rightDepth);
        if (distance > 1)
        {
            isBalanced = false;
        }

        return Math.Max(leftDepth, rightDepth);
    }
}