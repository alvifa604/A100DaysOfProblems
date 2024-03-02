
namespace Problems.Day2;

public class ValidPalindrome
{
    // 0p
    public static bool IsValidPalindrome(string s)
    {
        int p1 = 0;
        int p2 = s.Length - 1;

        while (p1 < p2)
        {
            char leftChar = s[p1];
            char rightChar = s[p2];

            // If the letter is not a word we skip it
            while (!char.IsLetterOrDigit(leftChar) && p1 < p2)
            {
                p1++;
                leftChar = s[p1];
            }

            while (!char.IsLetterOrDigit(rightChar) && p2 > p1)
            {
                p2--;
                rightChar = s[p2];
            }

            if (char.ToLower(leftChar) != char.ToLower(rightChar))
            {
                return false;
            }

            p1++;
            p2--;
        }

        return true;
    }
}
