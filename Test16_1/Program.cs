namespace Test16_1
{
    internal class Program
    {

        public bool solution(string s)
        {
            int count = 0;

            foreach(char c in s)
            {
                if(c == '(')
                {
                    count++;
                }
                else
                {
                    if(count == 0)
                    {
                        return false;
                    }
                    count--;
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