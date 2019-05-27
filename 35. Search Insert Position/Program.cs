using System;

class Program
{
    static void Main()
    {
        var nums = new int[] { 1, 3, 5, 6 };
        var target = 7;
        Console.WriteLine(SearchInsert(nums, target));
    }

    public static int SearchInsert(int[] nums, int target)
    {
        var insertIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                insertIndex = i;
                break;
            }
            if (nums[i] > target)
            {
                break;
            }
            if (nums[i] < target)
            {
                insertIndex = i + 1;
            }
        }

        return insertIndex;
    }
}