namespace Test21_1
{
    internal class Program
    {
        static void SelectionSort(List<int> list, int n)
        {
            for(int i = 0; i < n; i++)
            {


                for (int j = i + 1; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write("{0} ", list[k]);
                    }

                    Console.WriteLine();

                    if (list[i] > list[j])  // i가 j보다 작으면 오름차순, i가 j보다 크면 내림차순
                    {
                        Swap(list, i, j);
                    }
                }
            }
        }

        static void BubbleSort(List<int> list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write("{0} ", list[k]);
                    }

                    Console.WriteLine();

                    if (list[j - 1] > list[j])  // j - 1이 j 보다 크면 오름차순, j - 1이 j 보다 작으면 내림차순
                    {
                        Swap(list, j - 1, j);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> selectionlist = new List<int>();
            List<int> bubblelist = new List<int>();
            Random random = new Random();

            for(int i = 0; i < n; i++)
            {
                int rand = random.Next() % 100;

                selectionlist.Add(rand);
                bubblelist.Add(rand);
            }

            Console.WriteLine();
            Console.WriteLine();

            SelectionSort(selectionlist, n);

            for(int i = 0; i < n; i++)
            {
                Console.Write("{0} ", selectionlist[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            BubbleSort(bubblelist, n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", bubblelist[i]);
            }
        }

        static void Swap(List<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}