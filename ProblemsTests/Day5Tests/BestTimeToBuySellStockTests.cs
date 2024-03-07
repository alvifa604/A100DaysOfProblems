using Problems.Day5;

namespace ProblemsTests.Day5Tests;

public class BestTimeToBuySellStockTests
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitTest(int[] prices, int expected)
    {
        // Act
        int result = BestTimeToBuySellStock.MaxProfit(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}
