namespace DataStructures
{
    abstract class Stack<T>
    {
        protected IList<T> list;
        protected int length = 0;

        public abstract bool IsFull { get; }
        public bool IsEmpty { get { return length == 0; } }

        public abstract void Push(T item);
        public abstract T Pop();
    }
}