namespace DataStructures
{
    class SynchronizationQueue<T> : SyncQueue<T>
    {
        int queue_size;
        public override bool IsFull { get { return queue.Count == queue_size; } }

        public SynchronizationQueue(int queue_size)
        {
            this.queue_size = queue_size;
            gate = new SemaphoreSlim(0, queue_size);
            queue = new CircularQueue<T>(queue_size);
        }
    }
}
