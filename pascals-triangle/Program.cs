using System;
using System.Collections.Generic;

namespace pascals_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Generate(20);
            foreach (var item in result)
            {
                System.Console.WriteLine(string.Join(",", item));
            }
        }
        static IList<IList<int>> Generate(int numRows)
        {

            var result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                if (i == 0)
                {
                    result.Add(new List<int>() { 1 });
                    continue;
                }
                var preList = result[i - 1];
                var tList = new List<int>();
                if (preList.Count > 1)
                {
                    for (int j = 0; j < preList.Count; j++)
                    {
                        if (j + 1 < preList.Count)
                        {
                            tList.Add(preList[j] + preList[j + 1]);
                        }
                    }
                }
                tList.Insert(0, 1);
                tList.Add(1);
                result.Add(tList);
            }
            return result;
        }
    }
}
