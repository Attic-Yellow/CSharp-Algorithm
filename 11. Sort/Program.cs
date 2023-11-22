namespace _11._Sort
{
    internal class Program
    {
        // <선택 정렬>
        // 전체 데이터 중에서 가장 작은 값부터 하나씩 선택하여 정렬
        // 시간복잡도 -  평균 : O(N²)     최악 : O(N²)
        // 공간복잡도 -  O(1)
        // 안정정렬   -  O
        public static void SelectionSort(IList<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int minIndex = i;

                for(int j = i; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, minIndex, i);
            }
        }

        // <삽입 정렬>
        // 데이터를 하나씩 꺼내어 정렬된 자료 중 적합한 위치에 삽입하여 정렬
        // 시간복잡도 -  평균 : O(N²)     최악 : O(N²)
        // 공간복잡도 -  O(1)
        // 안정정렬   -  O
        public static void InserttionSort(IList<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int key = list[i];
                int j;
                for (j = i - 1; j >= 0 && key < list[j]; j--)
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = key;
            }
        }

        // <버블 정렬>
        // 서로 인접한 데이터를 비교하여 작으면 앞으로, 크면 뒤로 정렬 (오름차순 기준)
        // 시간복잡도 -  평균 : O(N²)     최악 : O(N²)
        // 공간복잡도 -  O(1)
        // 안정정렬   -  O
        public static void BubbleSort(IList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j - 1] > list[j])
                        Swap(list, j - 1, j);
                }
            }
        }

        // <병합 정렬 (MergeSort)>
        // 데이터를 2분할하여 정렬 후 병합
        // 분할정복을 통한 정렬 방법
        // 시간복잡도 -  평균 : O(NlogN)   최악 : O(NlogN)
        // 공간복잡도 -  O(N)
        // 안정정렬   -  O 
        public static void MergeSort(IList<int> list, int left, int right)
        {
            if (left == right) return;

            int mid = (left + right) / 2;

            MergeSort(list, left, mid);
            MergeSort(list, mid + 1, right);
            Merge(list, left, mid, right);
        }

        public static void Merge(IList<int> list, int left, int mid, int right)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = left;
            int rightIndex = mid + 1;

            // 분할되어 정렬된 List를 병합
            while(leftIndex <= mid && rightIndex <= right)
            {
                if (list[leftIndex] < list[rightIndex])
                {
                    sortedList.Add(list[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sortedList.Add(list[rightIndex]);
                    rightIndex++;
                }
            }
            if(leftIndex > mid)     // 왼쪽 List가 먼저 소진 되었을 경우
            {
                for(int i = rightIndex; i <= right; i++)
                {
                    sortedList.Add(list[i]);
                }
            }
            else    // 오른쪽 List가 먼저 소진 되었을 경우
            {
                for (int i = leftIndex; i <= mid; i++)
                {
                    sortedList.Add(list[i]);
                }
            }

            // 정렬된 sortedList를 List로 재복사
            for(int i = left; i <= right; i++)
            {
                list[i] = sortedList[i - left];
            }
        }

        // <퀵정렬>
        // 하나의 피벗을 기준으로 작은값과 큰값을 2분할하여 정렬
        // 시간복잡도 -  평균 : O(NlogN)   최악 : O(N²)
        // 공간복잡도 -  O(1)
        // 안정정렬   -  X
        public static void QuickSort(IList<int> list, int start, int end)
        {
            if (start >= end) return;

            int pivot = start;
            int left = pivot + 1;
            int right = end;

            while (left <= right) // 엇갈릴때까지 반복
            {
                // left가 pivot보다 큰 값을 만날때까지
                while (list[left] <= list[pivot] && left < end)
                {
                    left++;
                }
                // right가 pivot보다 작은 값을 만날때까지
                while (list[right] >= list[pivot] && right > start)
                {
                    right--;
                }

                if (left < right)       // 엇갈리지 않았다면
                {
                    Swap(list, left, right);
                }
                else                    // 엇갈렸다면
                {
                    Swap(list, pivot, right);
                }
            }

            QuickSort(list, start, right - 1);
            QuickSort(list, right + 1, end);
        }

        // <힙정렬>
        // 힙을 이용하여 우선순위가 가장 높은 요소가 가장 마지막 요소와 교체된 후 제거되는 방법을 이용
        // 배열에서 연속적인 데이터를 사용하지 않기 때문에 캐시 메모리를 효율적으로 사용할 수 없어 상대적으로 느림
        // 시간복잡도 -  평균 : O(NlogN)   최악 : O(NlogN)
        // 공간복잡도 -  O(1)
        // 안정정렬   -  X

        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> selectionList = new List<int>();
            List<int> insertionList = new List<int>();
            List<int> bubbleList = new List<int>();


            Console.Write("랜덤 데이터 : ");

            for(int i = 0; i < 20; i++)
            {
                int rand = random.Next() % 100;
                Console.Write("{0} ", rand);

                selectionList.Add(rand);
                insertionList.Add(rand);
                bubbleList.Add(rand);


            }

            Console.WriteLine();
            Console.WriteLine();

            SelectionSort(selectionList);
            Console.Write("선택 정렬 결과 : ");
            for(int i = 0; i < selectionList.Count; i++)
            {
                Console.Write("{0} ", selectionList[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            InserttionSort(insertionList);
            Console.Write("삽입 정렬 결과 : ");
            for (int i = 0; i < insertionList.Count; i++)
            {
                Console.Write("{0} ", insertionList[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            BubbleSort(bubbleList);
            Console.Write("버블 정렬 결과 : ");
            for (int i = 0; i < bubbleList.Count; i++)
            {
                Console.Write("{0} ", bubbleList[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

        }


        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}