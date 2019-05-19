using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;

        var result = TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        var rightHalfsLeftHalfsIndexes = new Dictionary<int, int>();
        var targetSumIndexes = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            var leftHalfSum = nums[i];
            if (rightHalfsLeftHalfsIndexes.ContainsKey(leftHalfSum))
            {
                var leftIndex = rightHalfsLeftHalfsIndexes[leftHalfSum];
                var rightIndex = i;
                targetSumIndexes[0] = leftIndex;
                targetSumIndexes[1] = rightIndex;

                break;
            }
            else
            {
                var rightHalfSum = target - nums[i];
                rightHalfsLeftHalfsIndexes[rightHalfSum] = i;
            }
        }

        return targetSumIndexes;
    }
}