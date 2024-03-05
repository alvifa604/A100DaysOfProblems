namespace Problems.Day4;

public static class RemoveDuplicates
{
    public static int Remove(int[] nums)
    {
        int k = nums[0];
        int j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != k)
            {
                j++;
                nums[j] = nums[i];
                k = nums[i];
            }
        }

        return j + 1;
    }
}
