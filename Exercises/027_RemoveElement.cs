// https://leetcode.com/problems/remove-element/

namespace LeetCode
{
    public static class RemoveNumber
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var count = nums.Length;
            for (int i = 0; i < count; i++)
            {
                if (nums[i] == val){
                    count--;
                    for (int j = i; j < count; j++)
                    {
                        nums[j] = nums[j+1];
                    }
                    i--;
                }
            }
            return count;
        }
    }
}