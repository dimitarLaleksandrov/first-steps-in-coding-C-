using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T> where T : IComparable<T>
    {
        private T[] Data;

        public CustomList()
        {
            this.Data = new T[0];
        }

        public void Add(T element)
        {
            T[] newCollection = new T[Data.Length + 1];
            for (int i = 0; i < Data.Length; i++)
            {
                newCollection[i] = Data[i];
            }
            newCollection[newCollection.Length - 1] = element;
            Data = newCollection;
        }

        public void Remove(int index)
        {
            if (index < this.Data.Length)
            {
                T[] removeFromCollection = new T[Data.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    removeFromCollection[i] = Data[i];
                }
                for (int i = index + 1; i < Data.Length; i++)
                {
                    removeFromCollection[i - 1] = Data[i];
                }
                Data = removeFromCollection;
            }
            else
            {
                Console.WriteLine("Item was NOT found");
            }
        }

        public bool Contains(T element)
        {
            foreach (var item in Data)
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
            T firstElement = Data[indexFirst];
            Data[indexFirst] = Data[indexSecond];
            Data[indexSecond] = firstElement;
        }

        public int Compare(T element)
        {
            int counter = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[i].CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public T Max()
        {
            T maxElement = Data[0];
            foreach (var item in Data)
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
            T minElement = Data[0];
            foreach (var item in Data)
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
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
