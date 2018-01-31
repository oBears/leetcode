using System;
using System.Collections.Generic;

namespace pascals_triangle_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetRow(6);
            System.Console.WriteLine(string.Join(",", result));
        }
        /*
        k == 0
        [1] 
        k == 1
        [11] 
        k == 2
        [111]  添加 1
        [121]  计算第 j个元素
        k == 3
        [1211]  添加 1
        [1331]   计算第 j个元素
        k == 4
        [13311]  添加 1
        [14641] 计算第 j个元素

        如果需要利用原有的集合吗，就需要从后往前计算，不然新的元素会导致计算不正确
         */
        static IList<int> GetRow(int rowIndex)
        {
            var result = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                result.Add(1);
                //若正序计算会覆盖掉原有数据
                for (int j = i - 1; j > 0; j--)
                    result[j] = result[j] + result[j - 1];
            }
            return result;
        }
    }
}
