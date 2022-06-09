using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class DoublyLinkedList
    {
        public int Count { get; set; }
        public LinkedListNode Head { get; private set; }
        public LinkedListNode Tail { get; private set; }
        public bool IsEmpty => this.Count == 0;
        private bool IsDisRevurse = false;
        public void AddHead(int value)
        {
            if(this.Count == 0)
            {
                this.Head = this.Tail = new LinkedListNode(value);
            }
            else
            {
                var newNode = new LinkedListNode(value);
                var previosHead = this.Head;
                previosHead.Previos = newNode;
                newNode.Next = previosHead;
                this.Head = newNode;
            }
            this.Count++;
        }
        public void AddTail(int value)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new LinkedListNode(value);
            }
            else
            {
                var newNode = new LinkedListNode(value);
                var previosTale = this.Tail;
                newNode.Previos = previosTale;
                previosTale.Next = newNode;
                this.Tail = newNode;
            }
            this.Count++;
        }
        public int RemoveHead()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove head becuse the list is empty");
            }
            var removeHead = this.Head;
            var removeHeadValue = removeHead.Value;
            var nextHead = removeHead.Next;
            if(nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.Previos = null;
                removeHead.Next = null;
                this.Head = nextHead;
            }
            this.Count--;
            return removeHeadValue;
        }
        public int RemoveTail()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove tail becuse the list is empty");
            }
            var removeTail = this.Tail;
            var removeTailValue = removeTail.Value;
            var nextTail = removeTail.Previos;
            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextTail.Next = null;
                removeTail.Previos = null;
                this.Tail = nextTail;
            }
            this.Count--;
            return removeTailValue;
        }
        public void ForEach(Action<int> action)
        {
            var curentNode = this.Head;
            while(curentNode != null)
            {
                action(curentNode.Value);
                curentNode = curentNode.Next;
            }
        }
        public List<int> ToList()
        {
            var list = new List<int>();
            this.ForEach(n => list.Add(n));
            return list;
        }
        public int[] ToArray()
        {
            var array = new int[this.Count];
            int counter = 0;
            //var currentNode = this.Head;
            //while(currentNode != null)
            //{
            //    array[counter++] = currentNode.Value;
            //    counter++;
            //    currentNode = currentNode.Next;
            //}
            this.ForEach(number =>
            {
                array[counter] = number;
                counter++;
            });
            return array;
        }
        public void LinkedListClear()
        {
            this.Head = this.Tail = null;
            this.Count = 0;
        }
        public class LinkedListNode
        {
            public LinkedListNode(int value)
            { 
                Value = value;
            }
            public int Value { get; set; }
            public LinkedListNode Next { get; set; }
            public LinkedListNode Previos { get; set; }
        }
    }
}
