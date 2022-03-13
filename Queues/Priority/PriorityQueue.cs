using DataStructures.Lists;

namespace DataStructures.Queues.Priority
{
    //private
    public struct ListItem<T>
    {
        public T? Value;
        public int Priority;

        public ListItem(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    class PriorityQueue<T>
    {
        //private
        public DynamicList<ListItem<T>> list = new DynamicList<ListItem<T>>();

        public void enQueue(T value, int priority)
        {
            if(list.Count == 0 || priority >= list[list.Count-1].Priority)
            {
                list.Add(new ListItem<T>(value, priority));
                return;
            }

            if (priority < list[0].Priority)
            {
                list.Insert(0, new ListItem<T>(value, priority));
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (priority >= list[i].Priority && priority < list[i+1].Priority)
                {
                    list.Insert(i+1, new ListItem<T>(value, priority));
                    return;
                }
            }

            list.Add(new ListItem<T>(value, priority));
        }

        public T? deQueue()
        {
            T? removed = list[0].Value;
            list.RemoveAt(0);
            return removed;
        }

        internal void debug_print()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Value: {item.Value}, Priority: {item.Priority}");
            }
        }
    }
}
