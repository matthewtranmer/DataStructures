using System.Collections;

namespace DataStructures.Lists
{
    abstract class List<T> : IEnumerable<T>, IList<T>
    {
        protected int length = 0;

        public int Count
        {
            get { return length; }
        }

        public virtual IEnumerator<T> enumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return this[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return enumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return enumerator();
        }

        protected void ValidateIndex(int index, int lower_bound, int upper_bound)
        {
            if (index > upper_bound || index < lower_bound)
            {
                throw new IndexOutOfRangeException();
            }
        }

        protected void ValidateIndex(int index)
        {
            ValidateIndex(index, 0, length - 1);
        }

        public abstract T this[int index] { get; set; }
        public abstract void Add(T item);
        public abstract void RemoveAt(int index);
        public abstract void Insert(int index, T item);
        public abstract void Clear();

        //Not Implemented
        public bool IsReadOnly { get => throw new NotImplementedException(); }
        //Not Implemented
        public int IndexOf(T _) => throw new NotImplementedException();
        //Not Implemented
        public bool Contains(T _) => throw new NotImplementedException();
        //Not Implemented
        public void CopyTo(T[] _, int __) => throw new NotImplementedException();
        //Not Implemented
        public virtual bool Remove(T _) => throw new NotImplementedException();
    }
}
