class Program
{
    static void Main()
    {
        var nums = new int[] { 3, 2, 2, 3 };
        var val = 3;
        System.Console.WriteLine(RemoveElement(nums, val));
    }

    public static int RemoveElement(int[] nums, int val)
    {
        var numsFilteredIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[numsFilteredIndex] = nums[i];
                numsFilteredIndex++;
            }
        }

        return numsFilteredIndex;
    }
}