using Common;
using System;

class Program
{
    static void Main()
    {
        var root1 = new TreeNode(1, 2, 3);
        var root2 = new TreeNode(1, 2, 3);
        Console.WriteLine(IsSameTree(root1, root2));
    }

    public static bool IsSameTree(TreeNode node1, TreeNode node2)
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

        if (IsSameTree(node1.left, node2.left) == false)
        {
            return false;
        }
        if (IsSameTree(node1.right, node2.right) == false)
        {
            return false;
        }

        return true;
    }
}