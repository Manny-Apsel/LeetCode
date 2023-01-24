namespace LeetCode
{
    public static class ThreeS
    {
public static IList<IList<int>> ThreeSum(int[] nums)
{
    var res = new List<IList<int>>();
    if (nums == null || nums.Length < 3)
    {
        return res;
    }
    Array.Sort(nums);
    int? prev = null;
    while (nums.Length > 2)
    {
        if (prev == nums[0])
        {
            nums = nums.Take(new Range(1, nums.Length)).ToArray();
            continue;
        }
        prev = nums[0];
        int val = (int)(0 - prev);
        int? pre = null;
        for (int i = 1; i < nums.Length; i++)
        {  
            if (pre == nums[i]){
                continue;
            }
            pre = nums[i];
            val -= (int) pre;
            var index = Array.BinarySearch(nums, i + 1, nums.Length - 1 - i, val);
            if (index > 0)
            {
                res.Add(new int[] { nums[0], nums[i], val });
            }
            val = 0 - nums[0];
        }
        var r = new Range(1, nums.Length);
        nums = nums.Take(r).ToArray();
    }
    return res;
}
    }
}