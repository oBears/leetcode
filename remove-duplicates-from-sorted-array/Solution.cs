using System;

public class Solution
{
    // 1 1 2 2 2 3 4 4 5 6
    //len 是新数组下标 ，输入的nums 是排过序的， 只需要对比新数组的最后一个与原有数据的数据不一样的
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length<2) return nums.Length;
        var len = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[len])
                nums[++len] = nums[i];
        }
        return len + 1;
    }
}