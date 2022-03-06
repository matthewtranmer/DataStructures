using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.Channels
{
    interface ISyncQueue<T>
    {
        void EnQueue(T item);
        Task<T> DeQueue();

        bool IsFull { get; }
        bool IsEmpty { get; }

        int Count { get; }
    }
}
