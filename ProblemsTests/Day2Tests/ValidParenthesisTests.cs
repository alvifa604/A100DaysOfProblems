using Problems.Day2;

namespace ProblemsTests.Day2Tests;

public class ValidParenthesisTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("[({})[]{}]", true)]
    [InlineData("[{({}})[()]{)}]", false)]
    [InlineData("(]", false)]
    [InlineData("(])", false)]
    [InlineData("([)]", false)]
    public void IsValidTests(string s, bool expected)
    {
        bool result = ValidParenthesis.IsValid(s);

        Assert.Equal(expected, result);
    }
}
