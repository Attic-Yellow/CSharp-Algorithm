using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test16_1
{
    internal class StackTest
    {
        public bool solution3(string s)
        {
            Stack<char> stack = new Stack<char>(s.Length);

            foreach (char c in s)
            {

                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                   
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            bool answer = false;
            return answer;
        }
    }
}
