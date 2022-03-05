namespace DataStructures
{
    /*
    class SynchronizationQueue<T> : ISyncQueue<T>
    {
        SemaphoreSlim gate;
        CircularQueue<T> queue;
        int size;

        public int items { get { return queue.items; } }

        public SynchronizationQueue(int size)
        {
            this.size = size;
            gate = new SemaphoreSlim(0, size);
            queue = new CircularQueue<T>(size);
        }

        public bool isFull()
        {
            if (gate.CurrentCount == size)
            {
                return true;
            }
            return false;
        }

        public void enQueue(T item)
        {
            gate.Release();
            queue.enQueue(item);
        }

        public async Task<T> deQueue()
        {
            await gate.WaitAsync();
            return queue.deQueue();
        }
    }*/
}
