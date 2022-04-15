using DataStructures.Queues.Standard;

namespace DataStructures.Queues.Channels
{
	public abstract class SyncQueue<T> : ISyncQueue<T>
	{
		protected IQueue<T>? queue;
		public SemaphoreSlim? gate;

		public int Count { get { return queue.Count; } }
		public bool IsEmpty { get { return queue.Count == 0; } }
		public abstract bool IsFull { get; }

		public void EnQueue(T item)
		{
			queue.EnQueue(item);
			gate.Release();
		}

		public async Task<T> DeQueue()
		{
			await gate.WaitAsync();
			return queue.DeQueue();
		}
	}
}