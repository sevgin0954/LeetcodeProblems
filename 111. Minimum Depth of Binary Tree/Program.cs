using Common;
using System;

class Program
{
    static void Main()
    {
        var root = new TreeNode(1);
        //var root = new TreeNode(3, 9, 20, null, null, 15, 7);
        Console.WriteLine(MinDepth(root));
    }

    public static int MinDepth(TreeNode root, int currentDepth = 0)
    {
        if (root == null)
        {
            return currentDepth;
        }

        var rightDepth = MinDepth(root.right, currentDepth + 1);
        var leftDepth = MinDepth(root.left, currentDepth + 1);

        if (root.left == null)
        {
            return rightDepth;
        }
        if (root.right == null)
        {
            return leftDepth;
        }
        else
        {
            return Math.Min(leftDepth, rightDepth);
        }
    }
}