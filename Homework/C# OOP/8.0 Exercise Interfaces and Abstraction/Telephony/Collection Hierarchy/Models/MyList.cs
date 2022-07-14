using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionHierarchy.Models
{
    using Interface;
    public class MyList<T> : IMyList<T>
    {
        private readonly IList<T> data;
        public MyList()
        {
            data = new List<T>();
        }
        public int Use => this.data.Count;

        public int Add(T item)
        {
            this.data.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            T elementToRemove = this.data.FirstOrDefault();
            if (elementToRemove != null)
            {
                this.data.Remove(elementToRemove);
            }
            return elementToRemove;
        }
    }
}
