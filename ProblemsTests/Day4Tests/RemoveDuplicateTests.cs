
using Problems.Day4;

namespace ProblemsTests.Day4Tests;

public class RemoveDuplicateTests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveTests(int[] nums, int expected)
    {
        var result = RemoveDuplicates.Remove(nums);

        Assert.Equal(expected, result);
    }
}
