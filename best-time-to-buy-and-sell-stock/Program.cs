using System;

namespace best_time_to_buy_and_sell_stock
{
    class Program
    {
        static void Main(string[] args)
        {

            var r1 = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            var r2 = MaxProfit(new int[] { 7, 6, 4, 3, 1});
            var r3 = MaxProfit(new int[] { 2, 1, 4 });
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
        }


        /*
        最大利润 =最高价格- 最低价格
         */
        static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;
            var minPrice = prices[0]; //最低价格 
            var max = 0; //最大利润
            for (int i = 0; i < prices.Length; i++)
            {
                //当前价格大于最低价格 计算利润
                if (prices[i] > minPrice)
                {
                    //对比原先最大利润，取最大的利润
                    max = Math.Max(prices[i] - minPrice, max);
                }
                else
                {
                    //当前价格小于最低价格 则当前价格为最低价格
                    minPrice = prices[i];
                }
            }
            return max;
        }
    }
}
