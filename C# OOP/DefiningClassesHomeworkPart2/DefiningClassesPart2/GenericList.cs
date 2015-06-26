namespace DefiningClassesPart2
{
    using System;
    using DefiningClassesPart2.Interface;
    using System.Text;
    public class GenericList<T> : IList<T>
    {
        private const int DefaultLength = 4;
        private int currentIndex;
        private int count;

        private T[] arr;

        public GenericList()
        {
            this.arr = new T[DefaultLength];
            this.currentIndex = 0;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (this.currentIndex == arr.Length)
            {
                this.AutoGrow();
            }
            this.arr[currentIndex] = element;
            this.currentIndex++;
            this.count++;
        }

        private void AutoGrow()
        {
            T[] extendArr = new T[this.arr.Length * 2];
            for (int i = 0; i < this.arr.Length; i++)
            {
                extendArr[i] = this.arr[i];
            }
            this.arr = extendArr;
        }

        public T AccessElement(int index)
        {
            T element = this.arr[index];
            if (index >= currentIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Not a valid index");
            }
            return element;
        }

        public void Remove(int index)
        {
            if (index >= currentIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Not a valid index");
            }

            for (int i = index; i < Count - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }
            currentIndex--;
            count --;
        }

        public void InsertAt(T element, int index)
        {
            if (index >= currentIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Not a valid index");
            }

            if (index == count)
            {
                this.Add(element);
                return;
            }

            if (count >= this.arr.Length - 1)
            {
                this.AutoGrow();
            }

            count++;
            currentIndex++;
            for (int i = count; i > index; i--)
            {
                this.arr[i] = this.arr[i - 1];
            }

            this.arr[index] = element;
        }

        public void Clear()
        {
            this.arr = new T[DefaultLength];
            this.count = 0;
            this.currentIndex = 0;
        }

        public string FindIndexOfElement(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.arr[i].Equals(value))
                {
                    return i.ToString();
                }
            }

            return "Not a valid value";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(arr[i]);
                if (i == count - 1)
                {
                    break;
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }

        public T this[int index]
        {
            get
            {
                if (index >= currentIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("Not a valid index");
                }
                return this.arr[index];
            }
            private set 
            {
                this.arr[index] = value;
            }
        }
    }
}