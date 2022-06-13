using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_Implement_the_CustomList_Class
{
    public class MyList
    {

        public MyList()
            //:this(4) if we wont to start at 4 elements;
        {

        }
        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }
        private int[] data;
        private int capacity;
        public int Count
        {
            get;
            private set;
        }
        public int this[int index]
        {
            get
            {
                this.ValidaitIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidaitIndex(index);
                this.data[index] = value;
            }
        }
        public void Add(int number)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = number;
            this.Count++;
        }
        public int RemoveAt(int index)
        {
            this.ValidaitIndex(index);
            var result = this.data[index];
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }
            this.Count--;
            return result;
        }
        public void Insert(int index, int element)
        {
            this.ValidaitIndex(index);
            this.Count++;
            if(this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.ShiftRight(index);
            this.data[index] = element;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstInddex, int secondIndex)
        {
            this.ValidaitIndex(firstInddex);
            this.ValidaitIndex(secondIndex);
            var firstValue = this.data[firstInddex];
            this.data[firstInddex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
        }
        public void Clear()
        {
            this.Count = 0;
            this.data = new int[this.capacity];
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.Count - 1 ; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }
        }
        private void Shrink()
        {
            var newCapacity = this.data.Length / 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
        private void ValidaitIndex(int index)
        {
            if(index >= 0 && index < this.Count)
            {
                return;
            }
            var message = this.Count == 0 ? "This list is empty" : $"This list has {this.Count} elements and it's zero-based and you are trying to access {index} index which is not in the list"; 
            throw new ArgumentException($"Index out of range. {message}");
        }
        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
    }
}
