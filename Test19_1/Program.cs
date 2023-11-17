namespace Test19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cheatkey = Console.ReadLine();

            CheatKey cheatKey = new CheatKey();

            cheatKey.Run(cheatkey);
        }
    }
}