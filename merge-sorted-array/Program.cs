using System;

namespace merge_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[10];
            nums1[0] = 1;
            nums1[1] = 3;
            nums1[2] = 3;
            nums1[3] = 4;
            nums1[4] = 5;
            nums1[5] = 6;

            var nums2 = new int[] { 1, 2, 3, 4 };
            Merge(nums1, 6, nums2, 4);
            System.Console.WriteLine(string.Join(",", nums1));

        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //因为 nums1.Length=m+n;
            //倒着排,比较两数组最后一个元素 大小，大的写入 nums1数组，并计算剩余的元素个数，
            //当 n>0 m=0 时 即 nums2 中还有元素 而nums1 中没有元素，则直接把nums2中的当前元素写入nums1; nums2的元素个数一直减少，而此时原先nums1 元素个数一直为0，直到nums2中的元素都写入nums1中
            //若n=0 则表示 nums2 中已没有元素，而剩下的元素 由于本身是排序过的，所以就不用再比较

            while (n > 0) nums1[n + m - 1] = (m == 0 || nums2[n - 1] > nums1[m - 1]) ? nums2[--n] : nums1[--m];
        }
    }
}
