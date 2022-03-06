using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Lists
{
    class DynamicSynchronizationQueue<T> : SyncQueue<T>
    {
        public override bool IsFull { get { return false; } }

        public DynamicSynchronizationQueue()
        {
            queue = new DynamicQueue<T>();
            gate = new SemaphoreSlim(0);
        }
    }
}
