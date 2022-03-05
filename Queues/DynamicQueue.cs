using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class DynamicQueue<T> : IQueue<T>
    {
        LinkedList<T> list;

        public bool isFull { get { return false; } }
        public bool isEmpty { 
            get{
                if(list.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int Count { 
            get {
                return list.Count;
            }
        }

        public DynamicQueue()
        {
            list = new LinkedList<T>();
        }

        public void enQueue(T item)
        {
            list.Add(item);
        }

        public T deQueue()
        {
            T item = list.Last();
            list.RemoveAt(list.Count - 1);

            return item;
        }


    }
}
