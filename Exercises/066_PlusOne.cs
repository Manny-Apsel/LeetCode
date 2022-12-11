// https://leetcode.com/problems/plus-one/

namespace LeetCode
{
    public static class PlusOne
    {
        public static int[] Plus(int[] digits)
        {
            int n = digits.Length - 1;

            bool digit = true;

            while (digit)
            {
                digits[n] += 1;
                if (digits[n] == 10)
                {
                    digits[n] = 0;

                    if (n == 0)
                    {
                        Stack<int> stack = new Stack<int>(digits);
                        stack.Push(1);
                        digits = stack.ToArray();
                        digit = false;
                    }
                    n = n - 1;
                }
                else
                {
                    digit = false;
                }
            }

            return digits;
        }

        public static int[] DoesNotWork(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}