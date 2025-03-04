using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CustomStack
{
    public class CustomStack<T>
    {
        private const int initCapacity = 4;
        public T[] Values { get; set; }

        public int count;

        public CustomStack()
        {
            this.Values = new T[initCapacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(T item)
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
            this.Values[this.count] = item;
            count++;
        }

        public T Pop() 
        {
            if (this.Values.Length == 0)
            {
                Console.WriteLine($"CustomeStack is empty");
            }
            var top = this.Values[0];
            return top;
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

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.Values[i]);
            }
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
