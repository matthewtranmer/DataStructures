namespace DataStructures.Queues.Standard
{
    public interface IQueue<T>
    {
        void EnQueue(T item);
        T DeQueue();

        bool IsFull { get; }
        bool IsEmpty { get; }

        int Count { get; }
    }
}
