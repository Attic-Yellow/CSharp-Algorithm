using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._ShortestPath
{
    class Dijkstra
    {
        /******************************************************
		 * 다익스트라 알고리즘 (Dijkstra Algorithm)
		 * 
		 * 특정한 노드에서 출발하여 다른 노드로 가는 각각의 최단 경로를 구함
		 * 방문하지 않은 노드 중에서 최단 거리가 가장 짧은 노드를 선택 후,
		 * 해당 노드를 거쳐 다른 노드로 가는 비용 계산
		 ******************************************************/
        const int INF = 999999;

        public static void dijkstra(int[,] graph, int start, bool[] visited, out int[] parent, out int[] distance)
        {
            int size = graph.GetLength(0);
            visited = new bool[size];
            parent = new int[size];
            distance = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
                distance[i] = INF;
            }

            distance[start] = 0;

            for (int i = 0; i < size; i++)
            {
                int minCost = INF;
                int minIndex = -1;

                // 1. 탐색하지 않은 정점 중 가장 가까운 정점부터 탐색
                for (int j = 0; j < size; j++)
                {
                    if (!visited[j] && distance[j] < minCost)   // 탐색하지 않았으면서, 가장 가까운 정점
                    {
                        minIndex = j;
                        minCost = distance[j];
                    }
                }
                if(minIndex < 0) // 더이상 탐색할 정점이 없는 경우
                {
                    break;
                }

                // 2. 직접연결된 거리보다 거쳐서 더 짧아지면 갱신
                for(int j = 0; j < size; j++)
                {
                    // c distance[j] : 목적지까지 직접 연결된 거리
                    // a distance[minIndex] : 탐색중인 정점까지 거리
                    // b graph[minIndex, j] : 탐색중인 정점부터 목적지의 거리
                    if (distance[j] < distance[minIndex] + graph[minIndex, j])  // 중간지점을 거쳐서 더 짧아지는 경우
                    {
                        distance[j] = distance[minIndex] + graph[minIndex, j];  // 
                        parent[j] = minIndex;
                    }
                }
                visited[minIndex] = true;
            }
        }

    }
}
