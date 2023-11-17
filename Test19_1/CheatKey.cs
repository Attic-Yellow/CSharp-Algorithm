using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test19_1
{
    class CheatKey
    {
        private Dictionary<string, Action> cheatDic;

        public void Run(string cheatKey)
        {
            cheatDic = new Dictionary<string, Action>();

            Action money = () =>
            {
                Money();
            };

            Action level = () =>
            {
                ThereIsNoCowLevel();
            };

            cheatDic.Add("ShowMeTheMoney", () => money());
            cheatDic.Add("ThereIsNoCowLevel", () => level());

            Dictionary<string, Action> newCheatDic 
            = (Dictionary<string, Action>)cheatDic.Where(item => item.Key.Contains(cheatKey)).ToDictionary(item => item.Key, item => item.Value);

            foreach(KeyValuePair<string, Action> entry in newCheatDic)
            {
                entry.Value();
            }
            

            // 조건문 없이 바로 탐색하여 치트키 발동
        }

        public void Money()
        {
            Console.WriteLine("자원 추가 치트키");
        }

        public void ThereIsNoCowLevel() 
        {
            Console.WriteLine("바로 승리하는 치트키");
        }

    }
}
