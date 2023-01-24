namespace LeetCode
{
    public static class NumberCombo
    {
        public static IList<string> LetterCombinations(string digits)
        {
            var res = new List<string>();
            if (digits.Length == 0) { return res; }
            res.Add("");

            var dict = new Dictionary<char, string[]>();
            dict.Add('2', new string[] { "a", "b", "c" });
            dict.Add('3', new string[] { "d", "e", "f" });
            dict.Add('4', new string[] { "g", "h", "i" });
            dict.Add('5', new string[] { "j", "k", "l" });
            dict.Add('6', new string[] { "m", "n", "o" });
            dict.Add('7', new string[] { "p", "q", "r", "s" });
            dict.Add('8', new string[] { "t", "u", "v" });
            dict.Add('9', new string[] { "w", "x", "y", "z" });

            foreach (var n in digits)
            {
                res = Reiterate(res, dict[n]);
            }
            // res.Sort();
            return res;
        }

        private static List<string> Reiterate(List<string> res, string[] letters)
        {
            var copy = new List<string>(res);
            for (int i = 0; i < letters.Length - 1; i++)
            {
                res = res.Concat(copy).ToList();
            }

            res.Sort();

            for (int i = 0; i < res.Count; i = i + letters.Length)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    res[i+j] += letters[j];
                }
            }

            return res;
        }
    }
}