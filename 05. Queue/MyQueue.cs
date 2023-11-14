using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Queue
{
    internal class MyQueue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;
        private int head;
        private int tail;

        public MyQueue() 
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
        }

        public int Count
        {
            get
            {
                if (head <= tail)
                {
                    return tail - head;
                }
                else
                {
                    return tail + (array.Length - head);
                }
            }
        }

        public void Enqueue(T item)
        {
            if(IsFull())
            {
                Grow();
            }
            array[tail] = item;
            MoveNext(ref tail);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            T result = array[head];
            MoveNext(ref head);
            return result;
        }

        private void Grow()
        {
            int newCapacity = array.Length * 2;
            T[] newArray = new T[newCapacity];


            if (head < tail)
            {
                Array.Copy(array, head, newArray, 0, tail);
            }
            else
            {
                Array.Copy(array, head, newArray, 0, array.Length - head);
                Array.Copy(array, 0, newArray, array.Length - head, tail);
            }

            /* 위 조건문과 기능은 같음 그리고 위의 조건문이 더 빠름
            int i = 0;
            while(head != tail)
            {
                newArray[i] = array[head];
                i++;
                MoveNext(ref head);
            }
            */

            head = 0;
            tail = Count;
        }

        private bool IsFull()
        {
            if(head == 0)
            {
                return tail == array.Length - 1;
            }
            else
            {
                return head == tail + 1;
            }
        }

        private bool IsEmpty()
        {
            return head == tail;
        }

        private void MoveNext(ref int index)
        {
            if(index == array.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }
    }
}
