// https://leetcode.com/problems/valid-parentheses/

namespace LeetCode
{
    public static class ValidParen
    {
        public static bool IsValid(string s)
        {
            var list = new Stack<char>();

            foreach (var ch in s)
            {
                switch (ch)
                {
                    case '(':
                    case '[':
                    case '{':
                        list.Push(ch);

                        break;
                    case ')':
                        if (list.FirstOrDefault() != '(')
                        {
                            return false;
                        }
                        else
                        {
                            list.Pop();
                        }
                        break;
                    case ']':
                        if (list.FirstOrDefault() != '[')
                        {
                            return false;
                        }
                        else
                        {
                            list.Pop();
                        }
                        break;
                    case '}':
                        if (list.FirstOrDefault() != '{')
                        {
                            return false;
                        }
                        else
                        {
                            list.Pop();
                        }
                        break;
                }

            }
            if (list.Count() != 0)
            {
                return false;
            }
            return true;
        }

        public static bool ShorterSolution(string s)
        {
            var list = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    list.Push(')');
                }
                else if (ch == '[')
                {
                    list.Push(']');
                }
                else if (ch == '{')
                {
                    list.Push('}');
                }
                else if (!list.Any() || list.Pop() != ch){
                    return false;
                }
            }

            return !list.Any();
        }
    }

}