using Common;
using System;

class Program
{
    static void Main()
    {
        var root = new TreeNode(5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1);
        var sum = 22;
        Console.WriteLine(HasPathSum(root, sum));
    }

    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }
        var dif = targetSum - root.val;
        if (dif == 0 && root.left == null && root.right == null)
        {
            return true;
        }

        var leftResult = HasPathSum(root.left, dif);
        var rightResult = HasPathSum(root.right, dif);

        return leftResult || rightResult;
    }
}