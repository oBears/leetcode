using System;

namespace maximum_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = MaxSubArray(nums);
            System.Console.WriteLine(result);
        }
        // nums[0,i] =nums[0,i-1]+nums[i]
        //
        static int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0], maxEndingHere = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
    }
}
