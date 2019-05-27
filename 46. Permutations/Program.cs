using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var nums = new int[] { 1, 1, 2 };
        var result = Permute(nums);
        Print.PrintLine(result);
    }

    public static IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();

        GenerateAllPermutation(result, nums);

        return result;
    }

    public static void GenerateAllPermutation(IList<IList<int>> result, int[] nums, int index = 0)
    {
        if (index == nums.Length)
        {
            result.Add((int[])nums.Clone());
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            Swap(nums, i, index);
            GenerateAllPermutation(result, nums, index + 1);
            Swap(nums, index, i);
        }
    }

    private static void Swap(int[] nums, int index1, int index2)
    {
        var num1 = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = num1;
    }
}