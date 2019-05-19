using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };
        //var nums = new int[] { -4, 2, 2 };
        var combinations = ThreeSum(nums);
        Print.PrintNumbersCollections(combinations);
    }

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var combinations = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            var searchedSum = 0 - nums[i];
            if (i != 0 && nums[i - 1] == nums[i])
            {
                continue;
            }

            var leftIndex = i + 1;
            var rightIndex = nums.Length - 1;
            while (leftIndex < rightIndex)
            {
                var currentSum = nums[leftIndex] + nums[rightIndex];
                if (currentSum == searchedSum)
                {
                    var currentCombination = new int[] { nums[i], nums[leftIndex], nums[rightIndex] };
                    combinations.Add(currentCombination);
                    while (leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex + 1])
                    {
                        leftIndex++;
                    }
                    while (leftIndex < rightIndex && nums[rightIndex] == nums[rightIndex - 1])
                    {
                        rightIndex--;
                    }

                    leftIndex++;
                    rightIndex--;
                }
                else if (currentSum < searchedSum)
                {
                    leftIndex++;
                }
                else if (currentSum > searchedSum)
                {
                    rightIndex--;
                }
            }
        }

        return combinations;
    }
}