using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface IQueue<T>
    {
        void EnQueue(T item);
        T DeQueue();

        bool IsFull { get; }
        bool IsEmpty { get; }

        int Count { get; }
    }
}
