using System;

namespace DataStructures
{
    class Stack<T>
    {
        T[] array;
        int top = -1;
        int size;

        public bool is_empty
        {
            get
            {
                if (top == -1)
                {
                    return true;
                }
                return false;
            }
        }

        public bool is_full
        {
            get
            {
                if (top + 1 == size)
                {
                    return true;
                }
                return false;
            }
        }

        public Stack(int size)
        {
            this.size = size;
            array = new T[size];
        }

        public void push(T item)
        {
            if (is_full)
            {
                throw new Exception("Stack is full");
            }

            array[++top] = item;
        }

        public T pop()
        {
            if (is_empty)
            {
                throw new Exception("Stack is empty");
            }

            return array[top--];
        }

        internal void debug_display()
        {
            foreach (T item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}