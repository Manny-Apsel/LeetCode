// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace LeetCode
{
    public static class MergedArrayMedian
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var comb = nums1.Concat(nums2).ToArray();
            Array.Sort(comb);
            if (comb.Length % 2 == 1)
            {
                return comb[comb.Length / 2];
            }
            else
            {
                double a = comb[(comb.Length / 2) - 1];
                double b = comb[comb.Length / 2];
                return (a + b) / 2;
            }
        }

        public static double BinarySearch(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            if (n1 < n2) return BinarySearch(nums2, nums1);

            int lo = 0, hi = n2 * 2;
            while (lo <= hi)
            {
                int mid2 = (lo + hi) / 2;
                int mid1 = n1 + n2 - mid2;

                double L1 = (mid1 == 0) ? int.MinValue : nums1[(mid1 - 1) / 2];
                double L2 = (mid2 == 0) ? int.MinValue : nums2[(mid2 - 1) / 2];
                double r1 = (mid1 == n1 * 2) ? int.MaxValue : nums1[mid1 / 2];
                double r2 = (mid2 == n2 * 2) ? int.MaxValue : nums2[mid2 / 2];

                if (L1 > r2) lo = mid2 + 1;
                else if (L2 > r1) hi = mid2 - 1;
                else return (Math.Max(L1, L2) + Math.Max(r1, r2)) / 2;

            }

            return -1;
        }
    }
}