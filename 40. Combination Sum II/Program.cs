using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = new int[] { 10, 1, 2, 7, 6, 1, 5 };
        var target = 8;
        var cominations = CombinationSum2(nums, target);
        Print.PrintLine(cominations);
    }

    public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var filteredCandidates = candidates.Where(c => c <= target).ToArray();
        Array.Sort(filteredCandidates);

        var combinations = new List<IList<int>>();
        GenerateAllUniqueCombinationWithSum(combinations, new Stack<int>(), filteredCandidates, target);

        return combinations;
    }

    private static void GenerateAllUniqueCombinationWithSum(
        IList<IList<int>> combinationResult,
        Stack<int> currentCombination,
        int[] nums,
        int targetSum, 
        int startIndex = 0)
    {
        if (targetSum == 0)
        {
            combinationResult.Add(currentCombination.ToArray());
            return;
        }
        if (targetSum < 0)
        {
            return;
        }

        for (int i = startIndex; i < nums.Length; i++)
        {
            if (i != startIndex && nums[i - 1] == nums[i])
            {
                continue;
            }

            currentCombination.Push(nums[i]);
            GenerateAllUniqueCombinationWithSum(combinationResult, currentCombination, nums, targetSum - nums[i], i + 1);
            currentCombination.Pop();
        }
    }
}