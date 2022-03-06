namespace DataStructures.Stacks
{
    interface IStack<T>
    {
        public bool IsFull { get; }
        public bool IsEmpty { get; }

        void Push(T item);
        T Pop();
    }
}
