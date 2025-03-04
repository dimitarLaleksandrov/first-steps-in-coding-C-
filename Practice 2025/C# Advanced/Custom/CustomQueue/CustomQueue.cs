using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        public CustomQueue()
        {
            count = 0;
            Values = new T[initCapacity];
        }

        private const int initCapacity = 4;

        public T[] Values { get; set; }

        public int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Enqueue(T value)
        {
            if (this.Values.Length == this.count)
            {
                var nextItems = new T[this.Values.Length + 1];
                for (int i = 0; i < this.Values.Length; i++)
                {
                    nextItems[i] = this.Values[i];
                }
                this.Values = nextItems;
            }
            this.Values[this.count] = value;
            count++;
        }

        public T Dequeue()
        {
            IsEmpty();
            count--;
            var lastElement = Values[Values.Length - 1];
            SwitchElements();
            return lastElement;
        }

        private void IsEmpty()
        {
            if (this.count == 0)
            {
                Console.WriteLine($"CustomeStack is empty");
            }
        }

        private T[] SwitchElements()
        {
            var newQueue = new T[this.Values.Length - 1];
            for (int i = 0; i < Values.Length - 1; i++)
            {
                newQueue[i] = Values[i];
            }
            this.Values = newQueue;
            return this.Values;
        }

        public T Peek(int index)
        { 
            var item = this.Values[index];
            if (index > this.Values.Length -1)
            {
                Console.WriteLine($"The index was not found");
            }
            for (int i = 0; i < this.Values.Length - 1; i++) 
            {
                if (i == index)
                {
                    item = this.Values[i];
                    break;
                }
            }
            return item;
        }

        public T[] ShiftLeft(int index)
        {
            if (index <= 0)
            {
                Console.WriteLine($"Canot Shift on Left");
            }
            if (index > this.Values.Length - 1)
            {
                Console.WriteLine($"Out of Array");
            }
            for (int i = 0; i <= this.Values.Length - 1; i++) 
            { 
                if(i == index)
                {
                    var oldItem = this.Values[i - 1];
                    this.Values[i -1] = this.Values[i];
                    this.Values[i] = oldItem;
                }
                this.Values[i] = this.Values[i];
            }
            return this.Values;
        }
        public T[] ShiftRight(int index)
        {
            if (index < 0)
            {
                Console.WriteLine($"Canot Shift on Left");
            }
            if (index >= this.Values.Length - 1)
            {
                Console.WriteLine($"Out of Array");
            }
            for (int i = 0; i <= this.Values.Length - 1; i++)
            {
                if (i == index)
                {
                    var oldItem = this.Values[i + 1];
                    this.Values[i + 1] = this.Values[i];
                    this.Values[i] = oldItem;
                }
                this.Values[i] = this.Values[i];
            }
            return this.Values;
        }

        public void Clear()
        {
            if (this.Values.Length == 0)
            {
                Console.WriteLine($"CustomeStack is empty");
            }
            Array.Clear(this.Values, 0, this.Count);
            this.count = 0;
        }

        public void Print()
        {
            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
        }

    }
}
