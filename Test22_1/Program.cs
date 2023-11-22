namespace Test22_1
{
    class Program
    {


        public static void Graph()
        {
            bool[,] graph1 = new bool[8, 8]
            {
                { false, false,  true, false,  true, false, false, false},
                { false, false,  true, false, false,  true, false, false},
                {  true,  true, false, false, false,  true,  true, false},
                { false, false, false, false, false, false, false,  true},
                {  true, false, false, false, false, false, false,  true},
                { false,  true,  true, false, false, false, false, false},
                { false, false,  true, false, false, false, false, false},
                { false, false, false,  true,  true, false, false, false},
            };



            bool[,] graph2 = new bool[8, 8]
            {
                { false, false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false, false},
                { false, false, false, false,  true,  true, false, false},
                { false,  true, false, false, false,  true, false,  true},
                { false, false, false, false, false, false, false, false},
                { false,  true, false, false, false, false, false, false},
                { false, false,  true, false, false,  true, false, false},
                { false, false, false, false, false, false,  true, false},
            };

            const int INF = int.MaxValue;

            int[,] graph3 = new int[8, 8]
            {
                { INF, INF,   8, INF,   2, INF, INF, INF},
                { INF, INF, INF, INF, INF, INF,   9, INF},
                {   8, INF, INF, INF, INF, INF,   1, INF},
                { INF, INF, INF, INF, INF,   1, INF,   4},
                {   2, INF, INF, INF, INF, INF, INF,   1},
                { INF, INF, INF,   1, INF, INF, INF, INF},
                { INF,   9,   1, INF, INF, INF, INF, INF},
                { INF, INF, INF,   4,   1, INF, INF, INF},
            };
        }

        static void Main(string[] args)
        {
            
        }
    }
}