// https://leetcode.com/problems/roman-to-integer/

namespace LeetCode
{

    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var romNum = new Dictionary<string, int>();
            romNum.Add("I", 1);
            romNum.Add("V", 5);
            romNum.Add("X", 10);
            romNum.Add("L", 50);
            romNum.Add("C", 100);
            romNum.Add("D", 500);
            romNum.Add("M", 1000);

            if (s.Length == 1)
            {
                return romNum.GetValueOrDefault(s);
            }

            var numInp = new int[s.Length];

            for (int i = 0; i < numInp.Length; i++)
            {
                numInp[i] = romNum[s[i].ToString()];
            }

            var count = 0;
            var localCount = 0;

            for (int i = 0; i < numInp.Length - 1; i++)
            {
                if (numInp[i] < numInp[i + 1])
                {
                    localCount += numInp[i];
                    count -= localCount;
                    localCount = 0;
                }
                else if (numInp[i] > numInp[i + 1])
                {
                    localCount += numInp[i];
                    count += localCount;
                    localCount = 0;
                }
                else if (numInp[i] == numInp[i + 1])
                {
                    localCount += numInp[i];
                }
            }

            if (numInp[numInp.Length - 1] <= numInp[numInp.Length - 2])
            {
                localCount += numInp.Last();
                count += localCount;
                localCount = 0;
            }
            else if (numInp[numInp.Length - 1] > numInp[numInp.Length - 2])
            {
                count -= localCount;
                count += numInp.Last();
            }

            return count;
        }
    }
}