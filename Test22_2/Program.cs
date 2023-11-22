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
                    var adjacentNode = node.mo[i];
                    if (adjacentNode.marked == false)
                    {
                        adjacentNode.marked = true;
                        stack.Push(adjacentNode);
                    }
                }
                Console.Write(node.data + ",");
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program(6);

            program.dfs(0);

        }
    }
}