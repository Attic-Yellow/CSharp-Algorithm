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

        public CheatKey()
        {
            cheatDic = new Dictionary<string, Action>();

            cheatDic.Add("ShowMeTheMoney", Money);
            cheatDic.Add("ThereIsNoCowLevel", ThereIsNoCowLevel);
        }

        public void Run(string cheatKey)
        {
            Action action = cheatDic[cheatKey];

            action?.Invoke();
            
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
