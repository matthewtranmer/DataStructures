using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class StaticStack<T> : Stack<T>
    {
        public override bool IsFull { get { return length == 0; } }

        public override void Push(T item)
        {
            list[length++] = item;
        }

        public override T Pop()
        {
            return list[--length];
        }

        public StaticStack(int size)
        {
            list = new T[size];
        }
    }
}
