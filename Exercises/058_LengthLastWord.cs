// https://leetcode.com/problems/length-of-last-word/

namespace LeetCode
{
    public static class LengthLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            var arr = s.Split(" ");
            var index = 0;
            for (int i = arr.Length-1; arr.Length-1 >= 0; i--)
            {
                if (arr[i].Length == 0){
                    continue;
                }
                else {
                    index = i;
                    break;
                }
            }
            return arr[index].Length;
        }
    }
}