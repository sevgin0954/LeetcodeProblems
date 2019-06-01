using Common;
using System;

class Program
{
    static void Main()
    {
        var root = new TreeNode(3, 9, 20, null, null, 15, 7);
        Console.WriteLine(MaxDepth(root));
    }

    public static int MaxDepth(TreeNode root, int currentDepth = 0)
    {
        if (root == null)
        {
            return currentDepth;
        }

        var leftDepth = MaxDepth(root.left, currentDepth + 1);
        var rightDepth = MaxDepth(root.right, currentDepth + 1);
        if (leftDepth > rightDepth)
        {
            return leftDepth;
        }
        else
        {
            return rightDepth;
        }
    }
}