using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MyList<T>
    {
        // 리스트의 크기를 지정
        private const int DefaultCapacity = 20;

        private T[] items;
        private int size;

        public MyList() 
        {
            items = new T[DefaultCapacity];
            size = 0;
        }

        public int Capacity { get { return items.Length; } }
        public int Count { get { return size; } }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if(index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if(size >= items.Length)
            {
                Grow();
            }

            items[size] = item;
            size++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);

            if (index < 0)
            {
                return false;
            }
            else
            {
                RemoveAt(index);
                return true;
            }
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }

            size--;
            Array.Copy(items, index+1, items, index, size - index);
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(items, item, 0, size);
        }

        public void Clear()
        {
            items = new T[DefaultCapacity];
            size = 0;
        }

        private void Grow()
        {
            int newCapacity = items.Length * 2;
            T[] newItmes = new T[newCapacity];

            for(int i = 0; i < size; i++)
            {
                newItmes[i] = items[i];
            }

            items = newItmes;
        }

        public T? Find(Predicate<T> match)
        {
            if (match == null) throw new ArgumentNullException();

            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                    return items[i];
            }

            return default(T);
        }

        public int FindIndex(Predicate<T> match)
        {
            return FindIndex(0, size, match);
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if (startIndex > size)
                throw new ArgumentOutOfRangeException();
            if (count < 0 || startIndex > size - count)
                throw new ArgumentOutOfRangeException();
            if (match == null)
                throw new ArgumentNullException();

            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (match(items[i])) return i;
            }
            return -1;
        }
    }
}