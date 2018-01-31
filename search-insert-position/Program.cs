using System;

namespace search_insert_position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target||nums[i] > target)
                    return i;
            }
            return nums.Length ;
        }
    }
}
