using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> colections;
        private int curentIndex;
        public ListyIterator(params T[] data)
        {
            colections = new List<T>(data);
            curentIndex = 0;
        }
        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", colections));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in colections)
            {
                yield return element;
            }
        }

        public bool HasNext() => curentIndex < colections.Count - 1;
        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                curentIndex++;
            }
            return canMove;
        }
        public void Print()
        {
            if(colections.Count == 0)
            {
                throw new AggregateException("Invalid Operation!");
            }
            Console.WriteLine($"{colections[curentIndex]}");
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
