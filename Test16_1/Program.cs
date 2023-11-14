namespace Test16_1
{
    internal class Program
    {

        public bool solution(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    count++;
                }
                else
                {
                    if (count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            if (count != 0)
            {
                return false;
            }

            bool answer = true;
            return answer;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            string str = Console.ReadLine();

            Console.WriteLine(program.solution(str));
        }
    }
}