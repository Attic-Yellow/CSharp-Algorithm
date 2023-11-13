using System.Dynamic;
using System.Linq;

namespace Race
{

    internal class Program
    {
        public string[] solution(string[] players, string[] callings)
        {
            Dictionary<string, LinkedListNode<string>> dict = new Dictionary<string, LinkedListNode<string>>();
            LinkedList<string> linkedlist = new LinkedList<string>();

            foreach (string player in players)
            {
                dict[player] = linkedlist.AddLast(player);
            }

            foreach (string calling in callings)
            {
                if (dict.ContainsKey(calling))
                {
                    LinkedListNode<string> node = dict[calling];
                    LinkedListNode<string> nodePrev = dict[calling].Previous;
                    if (node.Previous != null)
                    {
                        linkedlist.Remove(node);
                        linkedlist.AddBefore(nodePrev, dict[calling]);
                    }
                }
            }

            string[] answer = new List<string>(linkedlist).ToArray();

            return answer;
        }



        static void Main(string[] args)
        {
            Program program = new Program();

            string[] players = new string[] { "mumu", "soe", "poe", "kai", "mine" };
            string[] callings = new string[] { "kai", "kai", "mine", "mine" };

            program.solution(players, callings);
        }
    }
}