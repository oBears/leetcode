using System;

namespace remove_duplicates_from_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var nums = new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 5 };
            var len = so.RemoveDuplicates(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
