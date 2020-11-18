using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        public static bool IsValid(string s)
        {
            List<char> stack = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Add(s[i]);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else
                {

                    if (s[i] == ')')
                    {
                        if (stack[stack.Count - 1] == '(')
                        {
                            stack.RemoveAt(stack.Count - 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (s[i] == '}')
                    {
                        if (stack[stack.Count - 1] == '{')
                        {
                            stack.RemoveAt(stack.Count - 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (s[i] == ']')
                    {
                        if (stack[stack.Count - 1] == '[')
                        {
                            stack.RemoveAt(stack.Count - 1);
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string s = "()";
            bool result = IsValid(s);
            Console.WriteLine(s + "  :" + result);
            s = "()[]{}";
            result = IsValid(s);
            Console.WriteLine(s + "  :" + result);
            s = "(]";
            result = IsValid(s);
            Console.WriteLine(s + "  :" + result);
            s = "(])]";
            result = IsValid(s);
            Console.WriteLine(s + "  :" + result);
            s = "{[]}";
            result = IsValid(s);
            Console.WriteLine(s + "  :" + result);
            Console.ReadLine();
        }
    }
}
