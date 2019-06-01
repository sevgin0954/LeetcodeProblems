using Common;
using System;

class Program
{
    static void Main()
    {
        var root = new TreeNode(1, 2, 2, 3, 4, 4, 3);
        Console.WriteLine(IsSymmetric(root));
    }

    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null || (root.left == null && root.right == null))
        {
            return true;
        }
        if (root.left == null || root.right == null)
        {
            return false;
        }

        return CompareTreesMirror(root.left, root.right);
    }

    private static bool CompareTreesMirror(TreeNode node1, TreeNode node2)
    {
        if (node1 == null && node2 == null)
        {
            return true;
        }
        if (node1 == null || node2 == null)
        {
            return false;
        }
        if (node1.val != node2.val)
        {
            return false;
        }

        if (CompareTreesMirror(node1.left, node2.right) == false)
        {
            return false;
        }
        if (CompareTreesMirror(node1.right, node2.left) == false)
        {
            return false;
        }

        return true;
    }
}