using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Searching
{
    class Graph
    {
        /******************************************************
        * 그래프 (Graph)
        * 
        * 정점의 모음과 이 정점을 잇는 간선의 모음의 결합
        * 한 노드에서 출발하여 다시 자기 자신의 노드로 돌아오는 순환구조를 가짐
        * 간선의 방향성에 따라 단방향 그래프, 양방향 그래프가 있음
        * 간선의 가중치에 따라   연결 그래프, 가중치 그래프가 있음
        ******************************************************/

        // <인접 행렬 그래프>
        // 그래프 내의 각 정점의 연결관계를 나타내는 행렬
        // 2차원 배열을 [출발정점, 도착정점]으로 표현
        // 장점 : 연결여부 접근이 빠름 - 시간복잡도 : O(1)
        // 단점 : 메모리 사용량이 많음 - 공간복잡도 : O(N²)
        public void MatrixGraph()
        {
            bool[,] graph = new bool[5, 5];

            graph[0, 3] = true;
            graph[1, 4] = true;
            graph[4, 1] = true;
            bool isConnected = graph[1, 2];
        }

        // <인접리스트 그래프>
        // 그래프 내의 각 정점의 인접 관계를 표현하는 리스트
        // 인접한 간선만을 리스트에 추가하여 관리
        // 장점 : 메모리 사용량이 적음 - 공간복잡도 : O(N)
        // 단점 : 인접여부를 확인하기 위해 리스트 탐색이 필요 - 시간복잡도 : O(N)

        // 예시
        public void ListGraph()
        {
            List<List<int>> listGraph = new List<List<int>>();

            for(int i = 0; i < 5; i++)
            {
                listGraph.Add(new List<int>());
            }

            listGraph[0].Add(1);
            listGraph[0].Add(4);
            listGraph[1].Add(3);
            listGraph[2].Add(3);
        }
       
    }
}
