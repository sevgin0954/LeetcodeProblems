using System;

namespace _55._Jump_Game
{
    class Program
    {
        static void Main()
        {
            var nums = new int[] { 2, 3, 1, 5 };
            var canJump = CanJump(nums);

            Console.WriteLine(canJump);
        }

        public static bool CanJump(int[] nums)
        {
            var maxIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxIndex || maxIndex >= nums.Length - 1)
                {
                    break;
                }

                var currentMaxIndex = i + nums[i];
                if (currentMaxIndex > maxIndex)
                {
                    maxIndex = currentMaxIndex;
                }
            }

            return maxIndex >= nums.Length - 1;
        }
    }
}
