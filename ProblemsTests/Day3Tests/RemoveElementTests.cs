using Problems.Day3;

namespace ProblemsTests.Day3Tests;

public class Tests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3 })]
    public void RemoveTests(int[] nums, int val, int[] expectedNums)
    {
        int result = RemoveElement.Remove(nums, val);

        Assert.Equal(expectedNums.Length, result);
    }
}
