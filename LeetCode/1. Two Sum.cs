public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.ContainsKey(target - nums[i]))
            {
                return [seen[target - nums[i]], i];
            }

            seen[nums[i]] = i;
        }

        return [-1];
    }
}