using System.Collections;

namespace DataStructures.HashMaps
{
    class HashMap<T> : IEnumerable<string>
    {
        protected ArrayElement?[] array;
        protected int length = 0;
        protected const float percentage_multiplier = 0.3f;

        public int Count { get { return length; } }

        protected class ArrayElement
        {
            public T? item;
            public string key;

            public ArrayElement(string key, T? item)
            {
                this.item = item;
                this.key = key;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    yield return array[i].key;
                }
            }
        }

        protected int percentageIncrease(int number)
        {
            return number + (int)MathF.Ceiling(number * percentage_multiplier);
        }

        protected int percentageDecrease(int number)
        {
            return number - (int)MathF.Ceiling(number * percentage_multiplier);
        }

        public virtual T? Remove(string key)
        {
            int index = getElementIndex(key);
            T? removed_item = array[index].item;

            array[index] = null;

            length--;
            return removed_item;
        }
        
        private int getElementIndex(string key)
        {
            int hash = calculateHash(key) - 1;
            foreach (int jump in primeNumbers())
            {
                int index = (hash + jump) % array.Length;

                if (array[index] == null)
                {
                    throw new KeyNotFoundException();
                }

                if (array[index].key == key)
                {
                    return index;
                }
            }

            return default;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerable<int> primeNumbers()
        {
            for (int i = 2; true; i++)
            {
                bool is_prime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }

                if (is_prime) yield return i;
            }
        }

        private int calculateHash(string key)
        {
            int count = 0;
            foreach (char character in key)
            {
                count = count + character;
            }

            count = count % array.Length;
            return count;
        }

        public void Add(object key, object? item)
        {
            this[(string)key] = (T?)item;
        }

        protected virtual void addNewElement(string key, T? value, int index)
        {
            array[index] = new ArrayElement(key, value);
            length++;
        }

        public T? this[string key]
        {
            get
            {
                int index = getElementIndex(key);
                return array[index].item;
            }

            set
            {
                int hash = calculateHash(key) - 1;
                foreach (int jump in primeNumbers())
                {
                    int index = (hash + jump) % array.Length;
                    //key not in hashmap
                    if (array[index] == null)
                    {
                        addNewElement(key, value, index);
                        return;
                    }

                    //not a collision
                    if (array[index].key == key)
                    {
                        //modify value at key already in hashmap
                        array[index] = new ArrayElement(key, value);
                        return;
                    }
                }
            }
        }
    }
}