using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface ISyncQueue<T>
    {
        void enQueue(T item);
        Task<T> deQueue();

        bool is_full { get; }
        bool is_empty { get; }

        int items { get; }
    }
}
