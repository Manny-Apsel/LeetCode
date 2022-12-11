// https://leetcode.com/problems/sqrtx/

using System.Numerics;

namespace LeetCode
{
    public static class Sqrt
    {
        public static int MySqrt(int x)
        {

            BigInteger total = 0;
            var count = 0;

            do
            {
                count++;
                total = (ulong)count * (ulong)count;
            } while (total <= x);

            if (total < (ulong)x){
                count--;
            }
            return --count;


        }
    }
}