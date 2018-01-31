using System;

namespace remove_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]{3, 2, 2, 3};
            var so=new Solution();
            var result= so.RemoveElement(nums,3);
            for (int i = 0; i < nums.Length; i++)
             System.Console.WriteLine(nums[i]);
           
        }
    }
}
