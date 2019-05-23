using System;

class Program
{
    static void Main()
    {
        var nums = new int[] { 1, 1, 2 };
        Console.WriteLine(RemoveDuplicates(nums));
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        int currentUniqueNumIndex = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                nums[currentUniqueNumIndex] = nums[i];
                currentUniqueNumIndex++;
            }
        }

        return currentUniqueNumIndex;
    }
}