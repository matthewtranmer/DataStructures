namespace DataStructures.Lists
{
    class DynamicList<T> : List<T>
    {
        T[] array;
        int minimum_size;

        public override T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return array[index];
            }
            set
            {
                ValidateIndex(index);
                array[index] = value;
            }
        }

        public DynamicList(int minimum_size = 8)
        {
            this.minimum_size = minimum_size;
            array = new T[minimum_size];
        }

        private void expandArray()
        {
            T[] new_array = new T[array.Length * 2];
            array.CopyTo(new_array, 0);

            array = new_array;
        }

        private void reduceArray()
        {
            int new_length = array.Length / 2;
            T[] new_array = new T[new_length];

            for (int i = 0; i < new_length; i++)
            {
                new_array[i] = array[i];
            }

            array = new_array;
        }

        public override void Add(T item)
        {
            if (length+1 > array.Length)
            {
                expandArray();
            }

            array[length] = item;
            length++;
        }

        public override bool Remove(T item)
        {
            for (int i = length-1; i < length-1; i++)
            {
                if (array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public override void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (int i = index; i < length; i++)
            {
                array[i] = array[i + 1];
            }

            length--;

            int half = array.Length / 2;
            if (half >= minimum_size && length <= half)
            {
                reduceArray();
            }
        }

        public override void Clear()
        {
            array = new T[minimum_size];
            length = 0;
        }

        public override void Insert(int index, T item)
        {
            if (index == length)
            {
                Add(item);
            }

            ValidateIndex(index);

            T last = array[length-1];
            for (int i = length-1; i > index; i--)
            {
                array[i] = array[i-1];
            }

            Add(last);
            array[index] = item;
        }
    }
}
