


namespace DataStructures.HashMaps
{
    class StaticHashMap<T> : HashMap<T>
    {
        int hash_map_size;

        public StaticHashMap(int size)
        {
            hash_map_size = size;
            //increase array size by atleast 30% to increase efficiency
            array = new ArrayElement[percentageIncrease(size)];
        }

        protected override void addNewElement(string key, T? value, int index)
        {
            if(length + 1 > hash_map_size)
            {
                throw new IndexOutOfRangeException();
            }

            base.addNewElement(key, value, index);
        }
    }
}
