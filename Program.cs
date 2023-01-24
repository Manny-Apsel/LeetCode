namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = NumberCombo.LetterCombinations("23");

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
