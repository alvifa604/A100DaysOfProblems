using Problems.Day4;

namespace ProblemsTests.Day4Tests;

public class MayorityElementTests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void SolveTests(int[] nums, int expected)
    {
        int result = MajorityElement.Solve(nums);

        Assert.Equal(expected, result);
    }
}
