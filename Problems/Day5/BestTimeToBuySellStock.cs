namespace Problems.Day5;

public class BestTimeToBuySellStock
{
    public static int MaxProfit(int[] prices)
    {
        int buyP = 0;
        int sellP = buyP + 1;

        int maxProfit = 0;

        while (sellP < prices.Length)
        {
            int buyPrice = prices[buyP];
            int sellPrice = prices[sellP];

            if (sellPrice < buyPrice)
            {
                buyP = sellP;
            }
            else
            {
                int currProfit = sellPrice - buyPrice;
                maxProfit = Math.Max(currProfit, maxProfit);
            }

            sellP++;
        }

        return maxProfit;
    }
}
