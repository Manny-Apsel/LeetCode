namespace LeetCode
{
    public static class LongPaliSub
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            string res = "";

            for (int i = 0; i < s.Length - 1; i++)
            {
                var j = 0;

                // uneven palindrome => middle part is good 
                while (i - j >= 0 && i + j < s.Length)
                {
                    if (s[i - j] == s[i + j])
                    {
                        if ((2 * j) + 1 > res.Length)
                        {
                            res = "";
                            for (int k = i - j; k < i + j + 1; k++)
                            {
                                res += s[k];
                            }
                        }
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

                // even palindrome
                j = 0;

                while (i - j >= 0 && i + j + 1 < s.Length)
                {
                    if (s[i - j] == s[i + j + 1])
                    {
                        if ((2 * j) + 2 > res.Length)
                        {
                            res = "";
                            for (int k = i - j; k < i + j + 2; k++)
                            {
                                res += s[k];
                            }
                        }
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return res;
        }
    }
}