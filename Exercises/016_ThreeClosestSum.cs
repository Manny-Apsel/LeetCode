namespace LeetCode
{
    public static class ClosestThreeSum
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int res = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == target) { return sum; }
                    if (Math.Abs(target - sum) < Math.Abs(target - res))
                    {
                        res = sum;
                    }
                    if (sum > target)
                    {
                        --right;
                    } else {
                        ++left;
                    }
                }
            }
            return res;
        }
    }
}