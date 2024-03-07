using Problems.Day5;

namespace ProblemsTests.Day5Tests;

public class JumpGameTests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
    [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
    public void CanJumpTest(int[] nums, bool expected)
    {
        // Act
        bool result = JumpGame.CanJump(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
