using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02._LinkedList
{
    public class MyLinkedListNode<T>
    {
        public MyLinkedListNode<T> prev;
        public MyLinkedListNode<T> next;
        private T item;

        public MyLinkedListNode(T item)
        {
            this.prev = null;
            this.next = null;
            this.item = item;
        }

        public MyLinkedListNode(MyLinkedListNode<T> prev, MyLinkedListNode<T> next, T item)
        {
            this.prev = prev;
            this.next = next;
            this.item = item;
        }

        public MyLinkedListNode<T> Prev { get { return prev; } }
        public MyLinkedListNode<T> Next { get { return next; } }
        public T Item { get { return item; } }
    }

    internal class MyLinkedList<T>
    {
        private MyLinkedListNode<T> head;
        private MyLinkedListNode<T> tail;
        private int count;

        public MyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public MyLinkedListNode<T> AddFirst(T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>(value);

            // 다른 노느가 있었던 상황
            if( count > 0)
            {
                newnode.next = head;
                head.prev = newnode;
            }
            // 처음으로 추가하는 상황
            else
            {
                head = newnode;
            }
            count++;

            return newnode;
        }

        public MyLinkedListNode<T> AddLast(T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>(value);

            if(count > 0)
            {
                newnode.prev = tail;
                tail.next = newnode;
            }
            else
            {
                tail = newnode;
            }
            count++;

            return newnode;
        }

        public MyLinkedListNode<T> Find(T value)
        {
            MyLinkedListNode<T> current = head;
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            if(value != null)
            {
                while (current != null)
                {
                    if (comparer.Equals(current.Item, value))
                    {
                        return current;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                while (current != null)
                {
                    if (current.Item == null)
                    {
                        return current;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
            }
            return null;
        }

        public bool Remove(T value)
        {
            MyLinkedListNode<T> findnode = Find(value);

            // 못찾았음 == 연결리스트에 해당 데이터가 없었음
            if (findnode == null)
            {
                return false;
            }
            else
            {
                if(findnode.prev != null)
                {
                    findnode.prev.next = findnode.next;
                }
                else if (findnode.next != null)
                {
                    findnode.next.prev = findnode.prev;
                }
                
                count--;

                return true;
            }
        }

        public void Remove(MyLinkedListNode<T> node)
        {
            if(node.prev != null)
            {
                node.prev.next = node.next;
            }
            else
            {
                head = node.next;
            }

            if(node.next != null)
            {
                node.next.prev = node.prev;
            }
            else
            {
                tail = node.prev;
            }

            count--;
        }

        public MyLinkedListNode<T> AddBefore(MyLinkedListNode<T> node, T value)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T> (value);

            if(node != head)
            {
                node.prev.next = newNode;
                newNode.prev = node.prev;
            }
            else
            {
                head = newNode;
            }

            newNode.next = node;
            node.prev = newNode;

            count++;

            return newNode;
        }

        public MyLinkedListNode<T> AddAfter(MyLinkedListNode<T> node, T value)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(value);

            if (node != tail)
            {
                node.next.prev = newNode;
                newNode.next = node.next;
            }
            else
            {
                tail = newNode;
            }

            newNode.prev = node;
            node.next = newNode;

            count++;

            return newNode;
        }

        public MyLinkedListNode<T> First { get { return head; } }
        public MyLinkedListNode<T> Last { get { return tail; } }

        public int Count { get { return count; } }
    }
}