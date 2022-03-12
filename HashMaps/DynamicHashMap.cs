using DataStructures.Lists;

namespace DataStructures.HashMaps
{
    /*
    rules:
    1) The array length is always a power of two
    2) at least 30% of the array should always be empty
    
    logic:
    if length is over 80% of the array size, double
    if length is less than 80% of half of the array size, half
    */

    class DynamicHashMap<T> : HashMap<T>
    {
        const int MIN_SIZE = 8;

        public override T? Remove(string key)
        {
            T? removed_item = base.Remove(key);
            if (length <= percentageDecrease(array.Length/2) && array.Length/2>=MIN_SIZE)
            {
                decreaseStructure();
            }

            return removed_item;
        }

        private void changeStructureSize(int new_size)
        {
            ArrayElement?[] old_array = array;
            array = new ArrayElement?[new_size];

            length = 0;
            foreach (var element in old_array)
            {   
                if(element != null)
                {
                    this[element.key] = element.item;
                }
            }
        }

        private void increaseStructure()
        {
            changeStructureSize(array.Length * 2);
        }

        private void decreaseStructure()
        {
            changeStructureSize(array.Length / 2);
        }

        protected override void addNewElement(string key, T? value, int index)
        {
            base.addNewElement(key, value, index);

            if (length > percentageDecrease(array.Length))
            {
                increaseStructure();
            }
        }

        public DynamicHashMap()
        {
            array = new ArrayElement?[MIN_SIZE];
        }
    }
}
