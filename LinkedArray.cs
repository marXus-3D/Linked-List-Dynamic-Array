using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A
{
    internal class LinkedArray<T>
    {
        Node<T>? start;
        Node<T>? current;
        public int Count { get; set; }
        public void Add(T val) 
        {
            Node<T> node = new(val); 
            if (start == null) 
            {
                start = node;
            }
            else
            {
                if (current == null) 
                { 
                    start.next = node;
                    current = node;
                }
                else
                {
                    current.next = node;
                    current = node;
                }
            }
            ++Count;
        }
        public T Get(int idx) 
        {
            if (start == null || (current == null && idx > 0) || (current?.next == null && Count == idx))
                throw new IndexOutOfRangeException();

            
            var n = start;
            for (int i = 0; i < idx; i++) 
            {
                n = n?.next;
            }

            return n.data;
        }

        public void Set(int idx, T val)
        {
            if (start == null || (current == null && idx > 0) || (current?.next == null && Count == idx) || idx > Count) 
            {
                Add(val);
                return;
            }

            var n = start;
            for (int i = 0; i < idx; i++)
            {
                n = n?.next;
            }
            var tmp = new Node<T>(val)
            {
                next = n.next
            };
            n.next = tmp;
            
            ++Count;
        }

        public T First()
        {
            if (start == null)
                throw new IndexOutOfRangeException();
            return start.data;
        }
        public T Last()
        {
            if (current == null)
                throw new IndexOutOfRangeException();
            return current.data;
        }

        public T this[int idx] 
        {
            get { return Get(idx); }
            set { Set(idx, value); }
        }
    }
    class Node<T>
    {
        public T data;
        public Node<T>? next;
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
        public Node(T data)
        {
            this.data = data;
        }
    }
}
