using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        var nums = new int[] { 2, 7 };
        var targetSum = 9;

        var result = TwoSum(nums, targetSum);
        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] TwoSum(int[] nums, int targetSum)
    {
        var numsIndexes = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            var currentNum = nums[i];
            var currentDifference = targetSum - currentNum;

            if (numsIndexes.ContainsKey(currentDifference))
            {
                var leftIndex = numsIndexes[currentDifference];
                var rightIndex = i;
                return new int[] { leftIndex, rightIndex };
            }

            numsIndexes[currentNum] = i;
        }

        throw new InvalidOperationException("Not Found");
    }
}