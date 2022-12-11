namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = RemoveDuplicates.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2))));

            var tf = true;

            while (tf){
                System.Console.WriteLine(a.val);
                if (a.next != null){
                    a = a.next;
                }
                else {
                    tf = false;
                }
            }
        }
    }
}
