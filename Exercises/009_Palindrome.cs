// https://leetcode.com/problems/palindrome-number/

namespace LeetCode
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            var front = x.ToString().ToCharArray();
            var back = front.Reverse().ToArray();

            var length = Math.Ceiling((double)front.Length / 2);

            for (int i = 0; i < length; i++)
            {
                if (front[i] != back[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}