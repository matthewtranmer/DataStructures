namespace DataStructures.Queues.Standard
{
    class DynamicQueue<T> : Queue<T>
    {
        LinkedList<T> list;

        public override bool IsEmpty { get { return length == 0; } }
        public override bool IsFull{ get { return false; } }

        public DynamicQueue()
        {
            list = new LinkedList<T>();
        }

        public override void EnQueue(T item)
        {
            list.Add(item);
            length++;
        }

        public override T DeQueue()
        {
            T item = list[0];
            list.RemoveAt(0);
            length--;
            return item;
        }
    }
}
