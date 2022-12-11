// https://leetcode.com/problems/search-insert-position/

namespace LeetCode
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var addIndex = 0;
            var boolean = true;
            int[] arr = nums;
            do
            {
                var rest = arr.Length % 2 == 0 ? 0 : 1;
                var half = arr.Length / 2;

                if (arr[half] > target)
                {
                    arr = arr.Take(half).ToArray();

                }
                else if (arr[half] < target)
                {
                    addIndex += half + 1;
                    arr = arr.Skip(half + 1).ToArray();

                }
                else if (arr[half] == target)
                {
                    boolean = false;
                    return addIndex + half;
                }

                if (arr.Length == 0)
                {
                    boolean = false;
                }

            } while (boolean);
            return addIndex;
        }
    }
}