using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_LAB
{
    public class Box<T, V>
    {
        private Stack<T> stack;
        private Queue<V> queue;

        public Box()
        {
            this.stack = new Stack<T>();
            this.queue = new Queue<V>();
        }

        public int CountStack
        {
            get
            {
                return stack.Count;
            }
        }

        public int CountQueue
        {
            get
            {
                return queue.Count;
            }
        }

        public void AddT(T item)
        {
            stack.Push(item);
        }

        public T RemoveT()
        {
            T remove = stack.Peek();
            stack.Pop();
            return remove;
        }

        public void AddV(V item)
        {
            queue.Enqueue(item);
        }

        public V RemoveV()
        {
            V remove = queue.Peek();
            queue.Dequeue();
            return remove;
        }


    }
}
