namespace DataStructures.Queues.Standard
{
	public abstract class Queue<T> : IQueue<T>
	{
		protected int length = 0;

		public int Count { get { return length; } }
		public abstract bool IsEmpty { get; }
		public abstract bool IsFull { get; }

		public abstract void EnQueue(T item);
		public abstract T DeQueue();
	}
}
