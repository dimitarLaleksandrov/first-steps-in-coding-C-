using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    using Interface;
    public class AddCollection<T> : IAddCollection<T>
    {
        private ICollection<T> data;

        public AddCollection()
        {
            this.data = new List<T>();
        }

        public int Add(T item)
        {
            this.data.Add(item);
            return this.data.Count -1;
        }
    }
}
