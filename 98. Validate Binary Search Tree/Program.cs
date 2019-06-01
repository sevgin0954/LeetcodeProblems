using Common;
using System;

class Program
{
    static void Main()
    {
        TreeNode root = new TreeNode(2, 1, 3);
        Console.WriteLine(IsValidBST(root));
    }

    public static bool IsValidBST(TreeNode root, int? lowerValue = null, int? upperValue = null)
    {
        if (root == null)
        {
            return true;
        }

        var val = root.val;
        if (upperValue != null && val >= upperValue)
        {
            return false;
        }
        if (lowerValue != null && val <= lowerValue)
        {
            return false;
        }

        if (IsValidBST(root.left, lowerValue, val) == false)
        {
            return false;
        }
        if (IsValidBST(root.right, val, upperValue) == false)
        {
            return false;
        }

        return true;
    }
}