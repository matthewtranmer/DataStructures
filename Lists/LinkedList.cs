namespace DataStructures.Lists
{
    class LinkedList<T> : List<T>
    {
        ListElement<T>? first_element;
        ListElement<T>? last_element;

        public T Last
        {
            get { return last_element.data; }
        }

        class ListElement<T2>
        {
            public ListElement<T2>? next_element;
            public T2 data;

            public ListElement(T2 data, ListElement<T2>? next_element)
            {
                this.data = data;
                this.next_element = next_element;
            }
        }

        public override IEnumerator<T> enumerator()
        {
            ListElement<T>? element = first_element;
            for (int i = 0; i<length; i++)
            {
                yield return element.data;
                element = element.next_element;
            }
        }

        public override void Clear()
        {
            length = 0;
            first_element = null;
            last_element = null;
        }

        public override void Insert(int index, T item)
        {
            ValidateIndex(index, 0, length);

            //inserting to end
            if (index == length)
            {
                Add(item);
                return;
            }

            ListElement<T>? linking_element = GetListElementAtIndex(index - 1);
            linking_element.next_element = new ListElement<T>(item, linking_element.next_element);
            length++;
        }

        public override void RemoveAt(int index)
        {
            ValidateIndex(index);

            //one element
            if (length == 1)
            {
                length--;
                return;
            }

            //end of list
            if (index + 1 == length)
            {
                ListElement<T>? linking_element = GetListElementAtIndex(index - 1);

                linking_element.next_element = null;
                last_element = linking_element;
            }
            //start of list with multiple elements
            else if (index == 0)
            {
                first_element = first_element.next_element;
            }
            //element with surrounding elements
            else
            {
                ListElement<T>? linking_element = GetListElementAtIndex(index - 1);
                linking_element.next_element = linking_element.next_element.next_element;
            }

            length--;
        }

        public override void Add(T item)
        {
            if (length == 0)
            {
                first_element = new ListElement<T>(item, null);
                last_element = first_element;
            }
            else
            {
                last_element.next_element = new ListElement<T>(item, null);
                last_element = last_element.next_element;
            }

            length++;
        }

        private ListElement<T>? GetListElementAtIndex(int index)
        {
            if(index == length - 1)
            {
                return last_element;
            }

            ListElement<T>? temp_element = first_element;
            for (int i = 0; i < index; i++)
            {
                temp_element = temp_element.next_element;
            }

            return temp_element;
        }

        public override T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return GetListElementAtIndex(index).data;
            }
            set
            {
                ValidateIndex(index);
                GetListElementAtIndex(index).data = value;
            }
        }
    }
}
