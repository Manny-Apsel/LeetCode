// https://leetcode.com/problems/two-sum/

namespace LeetCode
{
    public static class one_TwoSums {
        public static int[] TwoSum(int[] nums, int target) {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++){
                for (int j = i + 1; j < nums.Length; j++){
                    if (nums[i] + nums[j] == target){
                        result[0] = i;
                        result[1] = j;
                        goto End;
                    }
                }
            }
            End: return result;
        }

        public static int[] HashTwo(int[] nums, int target){
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.ContainsKey(complement) && dict[complement] != i){
                    return new int[] {i, dict[complement]};
                }
            }

            return new int[2];
        }
    }
}