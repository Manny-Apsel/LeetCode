namespace LeetCode
{
    public static class StringToInt
    {
        public static int MyAtoi(string str)
        {
            if (String.IsNullOrEmpty(str) || str == null) return 0;
            int sign = 1, b = 0, i = 0;
            while (str[i] == ' ')
                i++;
            if (str[i] == '-' || str[i] == '+')
                sign = str[i++] == '-' ? -1 : 1;
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (b > Int32.MaxValue / 10 || (b == Int32.MaxValue / 10 && str[i] - '0' > 7))
                {
                    return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
                }
                b = 10 * b + (str[i++] - '0');
            }
            return b * sign;
        }
    }
}