using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test16_1
{
    class Test16_2
    {
        public bool solution2(string s)
        {
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    queue.Enqueue(s[i].ToString());
                }
                if (s[i] == '(')
                {
                    if (queue.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
                    
            }

            if (queue.Count != 0)
            {
                return false;
            }

            bool answer = true;
            return answer;
        }
    }
}
