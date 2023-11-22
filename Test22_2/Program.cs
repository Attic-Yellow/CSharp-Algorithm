using System.Runtime.InteropServices;

namespace Test22_2
{
    class Program
    {
        public class Node
        {
            public int data;
            public List<Node> mo;
            public bool marked;

            public Node(int data)
            {
                this.data = data;
                this.marked = false;
                this.mo = new List<Node>();
            }

        }

        Node[] nodes;
        public Program(int size)
        {
            nodes = new Node[size];
            for (int i = 0; i < size; i++)
            {
                nodes[i] = new Node(i);
            }
        }

        public void AddEdge(int i1, int i2)
        {
            Node n1 = nodes[i1];
            Node n2 = nodes[i2];

            if (!n1.mo.Contains(n2))
            {
                n1.mo.Add(n2);
            }

            if (!n2.mo.Contains(n1))
            {
                n2.mo.Add(n1);
            }
        }

        public void dfs(int index)
        {
            Node root = nodes[index];
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            root.marked = true;

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                for (int i = 0; i < node.mo.Count; i++)
                {
                    var moNode = node.mo[i];
                    if (moNode.marked == false)
                    {
                        moNode.marked = true;
                        stack.Push(moNode);
                    }
                }
                Console.Write("{0} ", node.data);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program(6);

            program.AddEdge(0, 1);
            program.AddEdge(0, 2);
            program.AddEdge(1, 3);
            program.AddEdge(2, 4);
            program.AddEdge(3, 5);

            program.dfs(0);

        }
    }
}