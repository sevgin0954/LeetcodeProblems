using System;

class Program
{
    static void Main()
    {
        //var nums = new int[] { -1, 2, 1, -4 };
        var nums = new int[] { -1, 0, 1, 1, 55 };
        var targetSum = 3;
        Console.WriteLine(ThreeSumClosest(nums, targetSum));
    }

    public static int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);

        var closestSum = int.MaxValue;

        var closestDistanceFromTarget = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i != 0 && nums[i - 1] == nums[i])
            {
                continue;
            }

            var leftIndex = i + 1;
            var rightIndex = nums.Length - 1;
            while (leftIndex < rightIndex)
            {
                var currentSum = nums[i] + nums[leftIndex] + nums[rightIndex];
                var currentDistanceFromTarget = Math.Abs(target - currentSum);
                if (currentDistanceFromTarget < closestDistanceFromTarget)
                {
                    closestDistanceFromTarget = currentDistanceFromTarget;
                    closestSum = currentSum;
                }
                else if (currentSum < target)
                {
                    leftIndex++;
                }
                else if (currentSum > target)
                {
                    rightIndex--;
                }
                else if (currentDistanceFromTarget == closestDistanceFromTarget)
                {
                    break;
                }
            }
        }

        return closestSum;
    }
}