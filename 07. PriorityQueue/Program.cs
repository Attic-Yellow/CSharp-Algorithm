using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace _07._PriorityQueue
{
    internal class Program
    {
        /*
        public class Monster
        {
            public string name;
            public int speed;
        }
        */


        public static void PQ()
        {

            // 우선순위 큐는 기본적으로 오름차순이다.
            // 내림차순으로 처리하고 싶으면 우선순위를 음수로 바꿔 준다 ( -를 곱하면 된다.)
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
            
            /*
            Monster monster = new Monster();
            pq.Enqueue(monster.name, monster.speed);
            */

            pq.Enqueue("슬라임", 5);
            pq.Enqueue("드래곤", 100);
            pq.Enqueue("오크", 20);
            pq.Enqueue("고블린", 50);

            while(pq.Count > 0)
            {
                string monsterName = pq.Dequeue();
                Console.WriteLine(monsterName);
            }

            
        }

        // <우선순위 큐 시간복잡도>
        // 최우선순위 데이터 확인         삽입         삭제
        //          O(1)               O(logN)      O(logN)

        // <배열기반 이었을 경우>
        // 최우선순위 데이터 확인         삽입          삭제 
        //          O(1)                O(N)          O(N)


        static void Main(string[] args)
        {
            
        }
    }
}