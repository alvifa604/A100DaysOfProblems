using Problems;

namespace ProblemsTests;

public class ValidAnagramTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "ab", false)]
    [InlineData("ab", "a", false)]
    public void IsAnagramTest(string s, string t, bool expected)
    {
        var result = ValidAnagram.IsAnagram(s, t);
        Assert.Equal(expected, result);
    }
}
