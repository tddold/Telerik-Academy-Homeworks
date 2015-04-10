namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> 
    {
        private const int DefaultCapacity = 16;

        private T[] listElements;
        private int count = 0;

        public GenericList() : this(DefaultCapacity)
        {
        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("The capacity can't be equal or smaller than 0");
            }
            else
            {
                this.listElements = new T[capacity];
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        // Indexator
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index");
                }
                else
                {
                    return this.listElements[index];
                }
            }
        }

        // Adding element
        public void AddElement(T element)
        {
            if (this.count == this.listElements.Length)
            {
                this.DoubleCapacity();
            }
            else
            {
                this.listElements[this.count] = element;
                this.count++;
            }
        }

        // Removing element by index
        public void RemoveElement(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            else
            {
                T[] newList = new T[this.listElements.Length];

                for (int i = 0; i < index; i++)
                {
                    newList[i] = this.listElements[i];
                }

                for (int i = index + 1; i < this.count; i++)
                {
                    newList[i - 1] = this.listElements[i];
                }

                this.listElements = newList;
                this.count--;
            }
        }

        // Inserting element by index
        public void InsertElement(int index, T element)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            else
            {
                T[] newList = new T[this.listElements.Length];

                for (int i = 0; i < index; i++)
                {
                    newList[i] = this.listElements[i];
                }

                newList[index] = element;

                for (int i = index + 1; i <= this.count; i++)
                {
                    newList[i] = this.listElements[i - 1];
                }

                this.listElements = newList;
                this.count++;
            }
        }

        // Clear the list
        public void ClearGenericList()
        {
            this.listElements = new T[DefaultCapacity];
            this.count = 0;
        }

        // Finding element by its value. Return the index if the element is found or -1 if it is not
        public int FindElement(T element)
        {
            for (int i = 0; i < this.listElements.Length; i++)
            {
                if (element.Equals(this.listElements[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        // Min
        public T Min<K>() where K : IComparable<T>
        {
            dynamic min = this.listElements[0];

            for (int i = 0; i < this.count; i++)
            {
                if (min.CompareTo(this.listElements[i]) == 1)
                {
                    min = this.listElements[i];
                }
            }

            return min;
        }

        // Max
        public T Max<K>() where K : IComparable<T>
        {
            dynamic max = this.listElements[0];

            for (int i = 0; i < this.count; i++)
            {
                if (max.CompareTo(this.listElements[i]) == -1)
                {
                    max = this.listElements[i];
                }
            }

            return max;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.listElements[i]);

                if (i != this.count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        // Double the capacity
        private void DoubleCapacity()
        {
            T[] newList = new T[this.listElements.Length * 2];

            for (int i = 0; i < this.listElements.Length; i++)
            {
                newList[i] = this.listElements[i];
            }

            this.listElements = newList;
        }
    }
}
