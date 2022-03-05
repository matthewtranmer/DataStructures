using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface IQueue<T>
    {
        void enQueue(T item);
        T deQueue();

        bool isFull { get; }
        bool isEmpty { get; }

        int Count { get; }
    }
}
