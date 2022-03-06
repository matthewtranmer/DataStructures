using System;

namespace DataStructures.Queues.Channels
{
	public abstract class SyncQueue<T> : ISyncQueue<T>
	{
		protected IQueue<T> queue;
		protected SemaphoreSlim gate;

		public int Count { get { return queue.Count; } }
		public bool IsEmpty { get { return queue.Count == 0; } }
		public abstract bool IsFull { get; }

		public void EnQueue(T item)
		{
			gate.Release();
			queue.EnQueue(item);
		}

		public async Task<T> DeQueue()
		{
			await gate.WaitAsync();
			return queue.DeQueue();
		}
	}
}