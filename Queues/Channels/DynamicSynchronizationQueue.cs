using DataStructures.Queues.Standard;

namespace DataStructures.Queues.Channels
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
