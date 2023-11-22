namespace Test20_1
{
    class Program
    {
        static void GetMaxSumAndRange(int n, int[] array)
        {
            int maxSum = array[0], currentSum = array[0];
            int start = 0, end = 0, tempStart = 0;

            for (int i = 1; i < n; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    tempStart = i;
                }
                else
                {
                    currentSum += array[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = tempStart;
                    end = i;
                }
            }

            Console.WriteLine($"최대 합: {maxSum}, 시작 지점: {start}, 종료 지점: {end}");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            GetMaxSumAndRange(n, array);
        }
    }
}