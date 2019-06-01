using Common;

class Program
{
    static void Main()
    {
        var nums = new int[] { 0, 1, 2, 3, 4, 5 };
        var rootNode = SortedArrayToBST(nums);
    }

    public static TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }

        return Converter(nums, 0, nums.Length - 1);
    }

    private static TreeNode Converter(int[] nums, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            return null;
        }

        int midIndex = (startIndex + endIndex) / 2;
        TreeNode node = new TreeNode(nums[midIndex]);
        node.left = Converter(nums, startIndex, midIndex - 1);
        node.right = Converter(nums, midIndex + 1, endIndex);
        return node;
    }
}