// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace LeetCode
{
    public static class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            return 0;
        
        int i = 0;
        
        for (int j = 0; j < nums.Length; j++)
        {
            nums[i++] = nums[j];
            
            while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                j++;
        }
        
        return i;
        }
    }
}