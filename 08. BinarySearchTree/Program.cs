namespace _08._BinarySearchTree
{
    internal class Program
    {
        /******************************************************
		 * 트리 (Tree)
		 * 
		 * 계층적인 자료를 나타내는데 자주 사용되는 자료구조
		 * 부모노드가 0개 이상의 자식노드들을 가질 수 있음
		 * 한 노드에서 출발하여 다시 자기 자신의 노드로 돌아오는 순환구조를 가질 수 없음
		 ******************************************************/

        /******************************************************
		 * 이진탐색트리 (BinarySearchTree)
		 * 
		 * 이진속성과 탐색속성을 적용한 트리
		 * 이진탐색을 통한 탐색영역을 절반으로 줄여가며 탐색 가능
		 * 이진 : 부모노드는 최대 2개의 자식노드들을 가질 수 있음
		 * 탐색 : 자신의 노드보다 작은 값들은 왼쪽, 큰 값들은 오른쪽에 위치
		 ******************************************************/

        // <이진탐색트리의 시간복잡도>
        // 접근			탐색			삽입			삭제
        // O(logN)		O(logN)	    O(logN)	    O(logN)
        // 최악의 경우
        // O(N)         O(N)        O(N)        O(N)

        // <이진탐색트리의 주의점>
        // 이진탐색트리의 노드들이 한쪽 자식으로만 추가되는 불균형 발생 가능
        // 이 경우 탐색영역이 절반으로 줄여지지 않기 때문에 시간복잡도 증가
        // 이러한 현상을 막기 위해 자가균형기능을 추가한 트리의 사용이 일반적
        // 대표적인 방식으로 Red-Black Tree, AVL Tree 등을 통해 불균형상황을 파악
        // 자가균형트리는 회전을 이용하여 불균형이 있는 상황을 해결

        // <트리순회>
        // 트리는 비선형 자료구조로 반복자의 순서에 대해 정의하는데 규칙을 선정해야 함
        // 순회의 방식은 크게 전위, 중위, 후위 순회가 있음
        // 전위순회 : 노드, 왼쪽, 오른쪽
        // 중위순회 : 왼쪽, 노드, 오른쪽   <- 이진탐색트리에서 중위순회시 오름차순으로 데이터를 순회가능
        // 후위순회 : 왼쪽, 오른쪽, 노드

        public class Monster
        {
            private string name;
            private int hp;
            private int attakc;
            private int level;

            public Monster(string _name, int _hp, int _attack, int _level)
            {
                this.name = _name;
                this.hp = _hp;
                this.attakc = _attack;
                this.level = _level;
            }
        }


        // 노드 기반이며 연결리스트와 비슷하다
        public static void BinarySearchTree()
        {
            SortedSet<int> sortedset = new SortedSet<int>();

            sortedset.Add(0);

            int search;
            sortedset.TryGetValue(0, out search);

            // key, value 이진탐색트리
            SortedDictionary<string, Monster> sortedDic = new SortedDictionary<string, Monster>();

            sortedDic.Add("파이리", new Monster("파이리", 35, 15, 5));
            sortedDic.Add("꼬부기", new Monster("꼬부기", 35, 15, 5));
            sortedDic.Add("이상해씨", new Monster("이상해씨", 35, 15, 5));
            sortedDic.Add("피카츄", new Monster("피카츄", 35, 15, 5));
            // 굉장히 많은 포켓몬스터 700 종

            Monster pikachu;

            sortedDic.TryGetValue("피카츄", out pikachu);          // 탐색시도

            // 인덱서를 통한 탐색
            if(sortedDic.ContainsKey("피카츄"))
            {
                pikachu = sortedDic["피카츄"];
            }
            else
            {
                pikachu = null;
            }
            
        }

        static void Main(string[] args)
        {
            BinarySearchTree();
        }
    }
}