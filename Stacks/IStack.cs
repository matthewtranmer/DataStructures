using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface IStack<T>
    {
        public bool IsFull { get; }
        public bool IsEmpty { get; }

        void Push(T item);
        T Pop();
    }
}
