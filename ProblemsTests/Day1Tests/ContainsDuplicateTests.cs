using Problems.Day1;

namespace ProblemsTests.Day1Tests;

public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 2, 3, 2 }, true)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void SolutionTests(int[] nums, bool expected)
    {
        var problem = new ContainsDuplicate();

        var result = problem.Solution(nums);

        Assert.Equal(expected, result);
    }
}
