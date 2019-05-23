using System;

class Program
{
    static void Main()
    {
        //var nums = new int[] { 5, 7, 7, 8, 8, 10 };
        var nums = new int[] { 1 };
        var target = 1;
        var range = SearchRange(nums, target);
        Console.WriteLine(string.Join(" ", range));
    }

    public static int[] SearchRange(int[] nums, int target)
    {
        var targetIndex = BinarySearch(nums, target);

        var startTargetIndex = targetIndex;
        var endTargetIndex = targetIndex;
        for (int i = targetIndex - 1; i >= 0; i--)
        {
            if (nums[i] == target)
            {
                startTargetIndex = i;
            }
        }
        for (int i = targetIndex + 1; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                endTargetIndex = i;
            }
        }

        return new int[] { startTargetIndex, endTargetIndex };
    }

    private static int BinarySearch(int[] arr, int searchedNum)
    {
        var searchedNumIndex = -1;

        int startIndex = 0;
        int endIndex = arr.Length - 1;
        while (startIndex <= endIndex)
        {
            var middleIndex = (startIndex + endIndex) / 2;
            if (arr[middleIndex] < searchedNum)
            {
                startIndex = middleIndex + 1;
            }
            else if (arr[middleIndex] > searchedNum)
            {
                endIndex = middleIndex - 1;
            }
            else
            {
                searchedNumIndex = middleIndex;
                break;
            }
        }

        return searchedNumIndex;
    }
}