namespace LeetCode
{
    public static class ContainerWater
    {
        public static int MaxArea(int[] height)
        {
            var i = 0;
            var j = height.Length - 1;
            var area = 0;

            while (i < j)
            {
                var cArea = (j - i) * Math.Min(height[i], height[j]);
                if (cArea > area)
                {
                    area = cArea;
                }
                if (height[i] < height[j]){
                    i++;
                }
                else {
                    j--;
                }
            }

            return area;
        }
    }
}