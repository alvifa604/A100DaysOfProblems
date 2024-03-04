
namespace Problems.Day3;

public class RemoveElement
{
    public static int Remove(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;

        while (i <= j)
        {
            if (nums[j] == val)
            {
                j--;
                continue;
            }

            if (nums[i] == val)
            {
                nums[i] = nums[j];
                i++;
                j--;
                continue;
            }

            i++;
        }

        return ++j;
    }
}
