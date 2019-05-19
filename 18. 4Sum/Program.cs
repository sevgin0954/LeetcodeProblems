using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new int[] { -1, 0, 1, 2, -1, -4 };
        var targetSum = -1;
        var combinations = FourSum(numbers, targetSum);
        Print.PrintNumbersCollections(combinations);
    }

    public static IList<IList<int>> FourSum(int[] nums, int targetSum)
    {
        Array.Sort(nums);

        var combinations = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i != 0 && nums[i - 1] == nums[i])
            {
                continue;
            }

            var searchedSum = targetSum - nums[i];
            var currentThreeCombinations = ThreeSumUnique(nums, searchedSum, i + 1);
            var currentFourCombinations = ConcatNumbersInFromOfNumbersCollections(currentThreeCombinations, nums[i]);
            combinations.AddRange(currentFourCombinations);
        }

        return combinations;
    }

    private static IList<IList<int>> ThreeSumUnique(int[] nums, int targetSum, int startIndex)
    {
        var combinations = new List<IList<int>>();

        for (int i = startIndex; i < nums.Length - 2; i++)
        {
            if (i != startIndex && nums[i - 1] == nums[i])
            {
                continue;
            }

            var searchedSum = targetSum - nums[i];
            var currentTwoCombinations = TwoSumUnique(nums, searchedSum, i + 1);
            var currentThreeCombinations =
                ConcatNumbersInFromOfNumbersCollections(currentTwoCombinations, nums[i]);
            combinations.AddRange(currentThreeCombinations);
        }

        return combinations;
    }

    private static IList<IList<int>> TwoSumUnique(int[] nums, int targetSum, int startIndex)
    {
        var combinations = new List<IList<int>>();

        int leftIndex = startIndex;
        int rightIndex = nums.Length - 1;
        while (leftIndex < rightIndex)
        {
            var currentSum = nums[leftIndex] + nums[rightIndex];
            if (currentSum == targetSum)
            {
                var currentCombination = new int[] { nums[leftIndex], nums[rightIndex] };
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
            else if (currentSum > targetSum)
            {
                rightIndex--;
            }
            else if (currentSum < targetSum)
            {
                leftIndex++;
            }
        }

        return combinations;
    }

    private static IList<IList<int>> ConcatNumbersInFromOfNumbersCollections(
        IList<IList<int>> numbersCollection, 
        params int[] nums)
    {
        var concatedNumbersCollections = new List<IList<int>>();

        foreach (var currentNumberCollection in numbersCollection)
        {
            concatedNumbersCollections.Add(nums.Concat(currentNumberCollection).ToList());
        }

        return concatedNumbersCollections;
    }
}