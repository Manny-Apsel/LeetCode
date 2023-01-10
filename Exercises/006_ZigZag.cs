namespace LeetCode
{
    public static class ZigZag
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var res = "";

            // distance between letters in column should be => (numRows * 2) - 2
            var distance = (numRows * 2) - 2;

            // first and n row have no char in between columns so distance should be var distance (d)
            // second and n row - 1 row have char in between them => x + y = d where if even n row x = d - (rowNum*2) and y = d - x
            for (int row = 0; row < numRows; row++)
            {
                var distanceFromStartToLetterInBetween = distance - (row * 2);

                for (int index = row; index < s.Length; index += distance)
                {
                    res += s[index];

                    if (distanceFromStartToLetterInBetween != 0 && distanceFromStartToLetterInBetween != distance && index + distanceFromStartToLetterInBetween < s.Length)
                    {
                        res += s[index + distanceFromStartToLetterInBetween];
                    }
                }
            }

            return res;
        }
    }
}