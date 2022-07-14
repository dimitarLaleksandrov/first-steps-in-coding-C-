using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    using Interface;
    using System.Linq;

    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        private IList<T> data;

        public AddRemoveCollection()
        {
            this.data = new List<T>();
        }

        public int Add(T item)
        {
            this.data.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            T elementToRemove = this.data.LastOrDefault();
            if (elementToRemove != null)
            {
                this.data.Remove(elementToRemove);
            }
            return elementToRemove;
        }
    }
}
