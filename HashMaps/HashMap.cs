using System.Collections;

namespace DataStructures.HashMaps
{
    class HashMap<T> : IEnumerable<T?>
    {
        ArrayElement[] array;
        int array_size;
        int hash_map_size;
        int length = 0;

        private class ArrayElement
        {
            public T? item;
            public string? key;

            public ArrayElement(string key, T? item)
            {
                this.item = item;
                this.key = key;
            }
        }

        public IEnumerator<T?> GetEnumerator()
        {
            for (int i = 0; i < array_size; i++)
            {
                if(array[i] != null)
                {
                    yield return array[i].item;
                }
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public HashMap(int size)
        {
            hash_map_size = size;
            //increase array size by atleast 35% to increase efficiency
            array_size = size + (int)MathF.Ceiling(size * 0.35f);
            array = new ArrayElement[array_size];
        }

        int calculateHash(string key)
        {
            int count = 0;
            foreach (char character in key)
            {
                count = count + character;
            }

            count = count % array_size;
            return count;
        }

        static IEnumerable<int> primeNumbers()
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

        public void Add(object key, object? item)
        {
            this[(string)key] = (T?)item;
        }

        public T? this[string key]
        {
            get
            {
                int hash = calculateHash(key) - 1;

                foreach (int jump in primeNumbers())
                {
                    int index = (hash + jump) % array_size;

                    if (array[index] == null)
                    {
                        throw new KeyNotFoundException();
                    }

                    if(array[index].key == key)
                    {
                        return array[index].item;
                    }
                }

                return default;
            }

            set
            { 
                int hash = calculateHash(key)-1;

                foreach(int jump in primeNumbers())
                {
                    int index = (hash + jump) % array_size;

                    if (array[index] == null && length+1>hash_map_size)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    //collision
                    if (array[index] != null && array[index].key != key) 
                    {
                        continue; 
                    }

                    if (array[index] == null)
                    {
                        length++;
                    }

                    array[index] = new ArrayElement(key, value);
                    break;
                }
            }
        }
    }
}
