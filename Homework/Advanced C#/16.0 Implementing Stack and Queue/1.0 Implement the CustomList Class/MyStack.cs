using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_Implement_the_CustomList_Class
{
    public class MyStack
    {
        public MyStack()
        {
            this.Count = 0;
            this.data = new int[INISHAL_CAPASITY];
        }
        private int[] data;
        private const int INISHAL_CAPASITY = 4;
        
        public int Count
        {
            get;
            private set;
        }
        public void Push(int element)
        {
            if (this.Count == data.Length)
            {
                this.ResizStack();
            }
            this.data[this.Count] = element;
            Count++;
        }
        public int Peek()
        {
            if(this.data.Length == 0)
            {
                throw new ArgumentException($"The Stack is empty");
            }
            int number = data[Count - 1];
            return number;
        }
        public int Pop()
        {
            if (this.data.Length == 0)
            {
                throw new ArgumentException($"The Stack is empty");
            }
            int number = data[this.Count - 1];
            data[this.Count - 1] = default(int);
            Count--;
            return number;
        }
        public void Clear()
        {
            this.Count = 0;
            this.data = new int[INISHAL_CAPASITY];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0 ; i--)
            {
                action(this.data[i]);
            }
        }

        private void ResizStack()
        {
            var newData = new int[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i]; 
            }
            this.data = newData;
        }
    }
}
