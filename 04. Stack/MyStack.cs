using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Stack
{
    internal class MyStack<T>
    {
        /******************************************************
	    * 어댑터 패턴 (Adapter)
	    * 
	    * 한 클래스의 인터페이스를 사용하고자 하는 다른 인터페이스로 변환
	    ******************************************************/

        private List<T> list;

        public void MyStakc()
        {
            list = new List<T>();
        }

        public int Count { get { return list.Count; } }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            return item;
        }
    }
}
