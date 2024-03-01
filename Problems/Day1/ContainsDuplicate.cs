namespace Problems.Day1;

public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        HashSet<int> set = new(nums);
        return set.Count != nums.Length;
    }
}
