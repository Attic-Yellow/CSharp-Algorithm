using System.Xml;

namespace _12._Searching
{
    internal class Program
    {
        // <순차 탐색>
        // 시간복잡도 - O(N)
        public static int SequentialSearch(IList<int> list, int item)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(item == list[i])
                {
                    return i;
                }
            }

            return -1;
        }

        // <이진 탐색>
        // 시간복잡도 - O(logN)
        public static int BinarySearch(IList<int> list, int item)
        {
            int low = 0;
            int high = list.Count - 1;

            while(low <= high)
            {
                int middle = (low + high) / 2;

                if (item > list[middle])
                {
                    low = middle + 1;
                }
                else if(item < list[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        // <깊이 우선 탐색 (DFS, Depth First Search)>
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 더이상 깊이 갈 곳이 없을 경우 다음 분기를 탐색하는 방식
        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for(int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
            SearchNode(graph, start, visited, parents);
        }

        private static void SearchNode(bool[,] graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true;

            for(int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] && !visited[i])     // 연결되어 있는 정점이거나 반문한적 없는 정점일 때

                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }


        // <넓이 우선 탐색 (BFS, Breadth First Search)> 
        // 그래프의 분기를 만났을 때 모든 분기를 한번씩 탐색한 뒤,
        // 다음 깊이를 탐색하는 방식
        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> bfsQueue = new Queue<int>();

            bfsQueue.Enqueue(start);
            while(bfsQueue.Count > 0)
            {
                int next = bfsQueue.Dequeue();
                visited[next] = true;

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[next, i] && !visited[i])         // 연결되어 있는 정점이면서, 방문한적 없는 정점
                    {
                        parents[i] = next;
                        bfsQueue.Enqueue(i);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}