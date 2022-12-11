// https://leetcode.com/problems/regular-expression-matching/
using System;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public static class RegularExpression
    {
        public static bool IsMatch(string s, string p)
        {
            var rg = new Regex("^" + p + "$");
            var match = rg.IsMatch(s);
            return match;
        }
    }
}