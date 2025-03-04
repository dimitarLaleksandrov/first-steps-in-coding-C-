using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LAB
{
    public class Box<T> where T : IComparable<T>
    {
        private T[] data { get; set; }

        public Box(T data)
        {
            this.data = new T[7]; 
        }

        public void Add(T element)
        {
            T[] newCollection = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newCollection[i] = data[i];
            }
            newCollection[newCollection.Length - 1] = element;
            data = newCollection;
        }


        public void Remove(int index)
        {
            if (index < this.data.Length)
            {
                T[] removeCollection = new T[data.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    removeCollection[i] = data[i];
                }
                for (int i = index + 1; i < data.Length; i++)
                {
                    removeCollection[i - 1] = data[i];
                }
                data = removeCollection;
            }
            else
            {
                throw new InvalidOperationException("Out of range");
            }
        }

        public bool Contains(T element)
        {
            foreach (var item in data)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int indexFirst, int indexSecond)
        {
            T firstElement = data[indexFirst];
            data[indexFirst] = data[indexSecond];
            data[indexSecond] = firstElement;
        }

        public int Compare(T element)
        {
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public T Max()
        {
            T maxElement = data[0];
            foreach (var item in data)
            {
                if (item.CompareTo(maxElement) > 0)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }

        public T Min()
        {
            T minElement = data[0];
            foreach (var item in data)
            {
                if (item.CompareTo(minElement) < 0)
                {
                    minElement = item;
                }
            }
            return minElement;
        }

        public void Print()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
