using Problems.Day2;

namespace ProblemsTests.Day2Tests;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData(".,", true)]
    [InlineData("0P", false)]
    public void IsPalindromeTest(string s, bool expected)
    {
        bool result = ValidPalindrome.IsValidPalindrome(s);

        Assert.Equal(expected, result);
    }
}
