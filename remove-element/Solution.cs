public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var len = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[len++] = nums[i];
        }
        return len;
    }
}