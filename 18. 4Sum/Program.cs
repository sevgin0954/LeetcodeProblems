using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new int[] { -1, 0, 1, 2, -1, -4 };
        var targetSum = -1;
        var combinations = FourSum(numbers, targetSum);
        Print.PrintLine(combinations);
    }

    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);

        var combinations = new List<IList<int>>();

        for (int i1 = 0; i1 < nums.Length - 3; i1++)
        {
            if (i1 > 0 && IsAlreasdyCalculated(nums, i1))
            {
                continue;
            }

            for (int i2 = i1 + 1; i2 < nums.Length - 2; i2++)
            {
                if (i2 > i1 + 1 && IsAlreasdyCalculated(nums, i2))
                {
                    continue;
                }

                var searchedSum = target - (nums[i1] + nums[i2]);

                var leftIndex = i2 + 1;
                var rightIndex = nums.Length - 1;
                while (leftIndex < rightIndex)
                {
                    var currentSum = nums[leftIndex] + nums[rightIndex];
                    if (currentSum > searchedSum)
                    {
                        rightIndex--;
                    }
                    else if (currentSum < searchedSum)
                    {
                        leftIndex++;
                    }
                    else
                    {
                        var currentCombination = new int[] { nums[i1], nums[i2], nums[leftIndex], nums[rightIndex] };
                        combinations.Add(currentCombination);

                        leftIndex++;
                        rightIndex--;

                        while (leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex - 1])
                        {
                            leftIndex++;
                        }
                        while (leftIndex < rightIndex && nums[rightIndex] == nums[rightIndex + 1])
                        {
                            rightIndex--;
                        }
                    }
                }
            }
        }

        return combinations;
    }

    private static bool IsAlreasdyCalculated(int[] nums, int index)
    {
        return nums[index - 1] == nums[index];
    }
}