namespace _02._LinkedList
{
    internal class Program
    {
        /******************************************************
		 * 연결리스트 (Linked List)
		 * 
		 * 데이터를 포함하는 노드들을 연결식으로 만든 자료구조
		 * 노드는 데이터와 이전/다음 노드 객체를 참조하고 있음
		 * 노드가 메모리에 연속적으로 배치되지 않고 이전/다음노드의 위치를 확인
		 ******************************************************/

        // <연결리스트 사용>
        public static void LinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();
            string[] players = new string[] { };

            // 연결리스트 요소 삽입
            linkedlist.AddFirst("0번 앞데이터");
            linkedlist.AddFirst("1번 앞데이터");
            linkedlist.AddLast("2번 뒤데이터");
            linkedlist.AddLast("3번 뒤데이터");
            
            int num = linkedlist.Count(); 
            // 연결리스트 요소 삭제
            linkedlist.Remove("2번 뒤데이터");

            LinkedListNode<string> findNode = linkedlist.Find("1번 앞데이터");

            // 연결리스트 노드를 통한 참조
            //<string> prevNode = findNode.Previous;
            //LinkedListNode<string> nextNode = findNode.Next;

            // 연결리스트 노드를 통한 노드 삽입
            linkedlist.AddBefore(findNode, "찾은노드 앞데이터");
            linkedlist.AddAfter(findNode, "찾은노드 뒤데이터");

            // 연결리스트 노드를 통한 삭제
            linkedlist.Remove(findNode);
            linkedlist.First();
            linkedlist.RemoveFirst();
            Console.WriteLine(num);
     
        }

        // <Linked List의 시간 복잡도>
        // 접근    탐색    삽입    삭제
        // O(n)    O(n)    O(1)    O(1)  

        static void Main(string[] args)
        {
            LinkedList();
        }
    }
}