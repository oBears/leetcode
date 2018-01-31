using System;

namespace best_time_to_buy_and_sell_stock_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*
            因为交易次数没有限制
            最大利润=所有利润的总和
         */
        static int MaxProfit(int[] prices)
        {
            var max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if ((prices[i + 1] - prices[i]) > 0)
                    max += prices[i + 1] - prices[i];
            }
            return max;
        }
    }
}
