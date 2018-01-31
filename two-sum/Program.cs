using System;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var ary = new int[] { 2, 7, 11, 15 };
            var result = so.TwoSum(ary, 9);
            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i]);
            }
            System.Console.ReadLine();
        }
    }
}
