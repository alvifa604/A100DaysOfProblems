namespace Problems.Day4;

public static class MajorityElement
{
    public static int Solve(int[] nums)
    {
        Dictionary<int, int> apps = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (apps.TryGetValue(num, out int value))
            {
                apps[num] = ++value;
            }
            else
            {
                apps.Add(num, 1);
            }
        }

        decimal times = Math.Floor((decimal)nums.Length / 2);
        int cand = 0;
        foreach (var kv in apps)
        {
            if (kv.Value > times)
            {
                cand = kv.Key;
            }
        }

        return cand;
    }
}
