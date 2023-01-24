namespace LeetCode
{
    public static class IntToRom
    {
        public static string IntToRoman(int num)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(1000, "M");
            dict.Add(900, "CM");
            dict.Add(500, "D");
            dict.Add(400, "CD");
            dict.Add(100, "C");
            dict.Add(90, "XC");
            dict.Add(50, "L");
            dict.Add(40, "XL");
            dict.Add(10, "X");
            dict.Add(9, "IX");
            dict.Add(5, "V");
            dict.Add(4, "IV");
            dict.Add(1, "I");

            var res = "";

            for (int i = 0; i < dict.Count(); i++)
            {
                while (num >= dict.ElementAt(i).Key)
                {
                    res += dict.ElementAt(i).Value;
                    num -= dict.ElementAt(i).Key;
                }
            }

            return res;
        }
    }
}