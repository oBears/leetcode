using System;

namespace plus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new int[] { 1, 2, 3, 9 };
            var result = PlusOne(digits);
            System.Console.WriteLine(string.Join("", result));
        }
        ///从 各位算起，如果为9 就变为0 ，继续下一位，如何不为9就+1 后返回， 最后判断首位是不是0，是0，代表是进位上来的，需要增加数组长度，首位是0只有一种情况
        /// 9999 这种， 所以 结果只是是 10000
        static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            if (digits[0] == 0)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }
            return digits;
        }
    }
}
