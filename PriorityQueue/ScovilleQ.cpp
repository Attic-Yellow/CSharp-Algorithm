// 23.11.15
// 프로그래머스 더 맵게 ( 자료구조 : 힙 연습문제 레벨 2)

#include <iostream>
#include <queue>
#include <vector>

using namespace std;

int solution(vector<int> scoville, int K)
{
    priority_queue<int> pq;
    int count = 0;

    for (int i = 0; i < scoville.size(); i++)
    {
        pq.push(-scoville[i]);
    }


    while (-pq.top() < K)
    {
        if (pq.size() < 2)
        {
            return -1;
        }

        int first = pq.top();
        pq.pop();
        int sc = (-1) * (first + (pq.top() * 2));
        pq.pop();

        pq.push(-sc);
        count++;
    }

    return count;
}

int main()
{
    vector<int> ar;
    int k = 7;
    int num = 0;

    for (int i = 0; i < 6; i++)
    {
        
        cin >> num;
        ar.push_back(num);
    }

    cout << solution(ar, k);
}
