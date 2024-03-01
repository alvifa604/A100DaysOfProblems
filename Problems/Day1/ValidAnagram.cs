namespace Problems;

/*
    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    typically using all the original letters exactly once.

    Example 1:
    Input: s = "anagram", t = "nagaram"
    Output: true
    
    Example 2:
    Input: s = "rat", t = "car"
    Output: false
*/
public class ValidAnagram
{
    // Space: O(n)
    // Time: O(n)
    public static bool IsAnagram(string s, string t)
    {
        // No point in continue if strings have different lengths
        if (s.Length != t.Length) return false;

        Dictionary<char, int> letterCount = [];
        for (int i = 0; i < s.Length; i++)
        {
            letterCount[s[i]] = letterCount.GetValueOrDefault(s[i], 0) + 1;
            letterCount[t[i]] = letterCount.GetValueOrDefault(t[i], 0) - 1;
        }

        return letterCount.All(kv => kv.Value == 0);
    }
}
