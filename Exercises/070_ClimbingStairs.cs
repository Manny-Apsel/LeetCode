// https://leetcode.com/problems/climbing-stairs/

namespace LeetCode
{
    public static class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            
            for (int i = 2; i < n; i++)
            {
                list.Add(list[i-1] + list[i-2]);
            }

            return list[n-1];
        }
    }
}