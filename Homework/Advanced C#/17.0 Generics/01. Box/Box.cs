using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Box
{
    public class Box<T>
    {
        public Box()
        {
            this.data = new List<T>();
        }
        public int Count => this.data.Count;
        private List<T> data;
        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remuve()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("The Box is empty");
            }
            var lastElement = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return lastElement;
        }
    }
}
