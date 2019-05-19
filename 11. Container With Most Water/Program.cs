using System;

class Program
{
    static void Main()
    {
        var heights = new int[] { 1, 20, 1, 2, 5, 90, 20, 2, 7 };
        //var heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 2, 7 };
        //var heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        Console.WriteLine(MaxArea(heights));
    }

    public static int MaxArea(int[] heights)
    {
        var maxArea = 0;

        var leftIndex = 0;
        var rightIndex = heights.Length - 1;
        while (leftIndex < rightIndex)
        {
            var currentArea = CalculateCurrentArea(heights, leftIndex, rightIndex);
            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            var leftSideHeight = heights[leftIndex];
            var rightSideHeight = heights[rightIndex];
            if (leftSideHeight > rightSideHeight)
            {
                rightIndex--;
            }
            else
            {
                leftIndex++;
            }
        }

        return maxArea;
    }

    private static int CalculateCurrentArea(int[] heights, int leftIndex, int rightIndex)
    {
        var leftSideHeight = heights[leftIndex];
        var rightSideHeight = heights[rightIndex];
        var distance = rightIndex - leftIndex;

        return Math.Min(leftSideHeight, rightSideHeight) * distance;
    }
}