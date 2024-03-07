namespace Problems.Day5;

public class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        int lastIndex = nums.Length - 1;
        int prev = nums.Length - 2;

        while (prev >= 0)
        {
            int jump = nums[prev];
            if (prev + jump >= lastIndex)
            {
                lastIndex = prev;
            }

            prev--;
        }

        return lastIndex == 0;
    }
}
