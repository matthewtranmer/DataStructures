using System;

namespace DataStructures.Stacks
{
    class DynamicStack<T> : Stack<T>
    {
        public override bool IsFull { get { return false; } }

        public override void Push(T item)
        {
            list.Add(item);
            length++;
        }

        public override T Pop()
        {
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            length--;

            return item;
        }

        public DynamicStack()
        {
            list = new Lists.LinkedList<T>();
        }
    }
}