using System;

namespace DataStructures
{
    class CircularQueue<T> : Queue<T>
    {
        int front = -1;
        int back = -1;
        int array_size;

        T[] array;

        public override bool IsEmpty {
            get
            {
                return front == -1 && back == -1;
            }
        }

        public override bool IsFull
        {
            get { return (back + 1) % array_size == front; }
        }

        public CircularQueue(int array_size)
        {
            this.array_size = array_size;
            array = new T[array_size];
        }

        public override void EnQueue(T item)
        {
            if (IsFull)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty)
            {
                front = 0;
                back = 0;
                array[back] = item;
            }
            else
            {
                back = ++back % array_size;
                array[back] = item;
            }

            length++;
        }

        public override T DeQueue()
        {
            T item = array[front];

            if (front == back)
            {
                front = -1;
                back = -1;
            }
            else
            {
                front = ++front % array_size;
            }

            length--;
            return item;
        }
    }
}