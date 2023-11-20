namespace Test20_1
{
    class Program
    {
        static int Maxnum(int n, int[] array)
        {
            int sum = array[0];

            for(int i = 1; i < n - 1; i++)
            {
                if (sum > array[i] + array[i + 1])
                {
                    sum = array[i + 1];
                    continue;
                }
                else
                {
                    sum += array[i + 1];
                }
            }
            Console.WriteLine(sum);
            return sum;
        }

        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());  
            int[] array = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                array[i] = (int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(Maxnum(n,array));
        }
    }
}