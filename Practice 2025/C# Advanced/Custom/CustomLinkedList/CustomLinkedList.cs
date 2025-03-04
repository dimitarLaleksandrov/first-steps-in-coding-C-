using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

    }

    public class CustomLinkedList<T>
    {
        
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Count { get; set; }

        public void AddHead(T value)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new Node<T>(value);
            }
            else
            {
                var newNode = new Node<T>(value);
                var previosHead = this.Head;
                previosHead.Prev = newNode;
                newNode.Next = previosHead;
                this.Head = newNode;
            }
            this.Count++;
        }

        public void AddTail(T value)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new Node<T>(value);
            }
            else
            {
                var newNode = new Node<T>(value);
                var previosTale = this.Tail;
                newNode.Prev = previosTale;
                previosTale.Next = newNode;
                this.Tail = newNode;
            }
            this.Count++;
        }

        public T RemoveHead()
        {
            if (this.Count == 0)
            {
                Console.WriteLine("Cannot remove head becuse the list is empty");
            }
            var removeHead = this.Head;
            var removeHeadValue = removeHead.Value;
            var nextHead = removeHead.Next;
            if (nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.Prev = null;
                removeHead.Next = null;
                this.Head = nextHead;
            }
            this.Count--;
            return removeHeadValue;
        }

        public T RemoveTail()
        {
            if (this.Count == 0)
            {
                Console.WriteLine("Cannot remove tail becuse the list is empty");
            }
            var removeTail = this.Tail;
            var removeTailValue = removeTail.Value;
            var nextTail = removeTail.Prev;
            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextTail.Next = null;
                removeTail.Prev = null;
                this.Tail = nextTail;
            }
            this.Count--;
            return removeTailValue;
        }

        public void ForEach(Action<T> action)
        {
            var curentNode = this.Head;
            while (curentNode != null)
            {
                action(curentNode.Value);
                curentNode = curentNode.Next;
            }
        }
        public List<T> ToList()
        {
            var list = new List<T>();
            this.ForEach(n => list.Add(n));
            return list;
        }
        public T[] ToArray()
        {
            var array = new T[this.Count];
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
        public void CustomLinkedListClear()
        {
            this.Head = this.Tail = null;
            this.Count = 0;
        }
    }
}
