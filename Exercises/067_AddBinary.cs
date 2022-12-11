// https://leetcode.com/problems/add-binary/

namespace LeetCode
{
    public static class AddBinary
    {
        public static string? BinaryCalc(string a, string b)
        {
            var carry = 0;
            int i = a.Length - 1,
                j = b.Length - 1;
            var res = new Stack<int>();

            while (i >= 0 || j >= 0)
            {
                var sum = carry;
                if (j >= 0) { sum += int.Parse(b[j--].ToString()); }
                if (i >= 0) { sum += int.Parse(a[i--].ToString()); }
                res.Push(sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) { res.Push(carry); }
            return String.Join("", res);
        }
    }
}