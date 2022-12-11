// https://leetcode.com/problems/longest-common-prefix/

namespace LeetCode
{
    public static class LongCommonPref
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var inp = strs.OrderBy(s => s.Length).ToArray();

            var output = "";

            for (int i = 0; i < inp[0].Length; i++)
            {
                var toCheck = inp[0][i];

                for (int j = 1; j < inp.Length; j++)
                {
                    if (toCheck != inp[j][i])
                    {
                        return output;
                    }
                }
                output += toCheck;
            }
            return output;
        }

        public static string SolutionThree(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            return LongestCommonPrefix(strs, 0, strs.Length - 1);
        }

        private static string LongestCommonPrefix(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            else
            {
                int mid = (l + r) / 2;
                var lcpLeft = LongestCommonPrefix(strs, l, mid);
                var lcpRight = LongestCommonPrefix(strs, mid + 1, r);
                return commonPrefix(lcpLeft, lcpRight);
            }
        }

        private static string commonPrefix(string lcpLeft, string lcpRight)
        {
            int min = Math.Min(lcpLeft.Length, lcpRight.Length);
            for (int i = 0; i < min; i++)
            {
                if (lcpLeft[i] != lcpRight[i])
                {
                    return lcpLeft.Substring(0, i);
                }
            }
            return lcpLeft.Substring(0, min);
        }
    }
}