using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public Box(T element)
        {
            Element = element;
        }
        public Box(List<T> elements)
        {
            Elements = elements;
        }
        public List<T> Elements
        {
            get;
        }
        public T Element
        {
            get;
        }
        public void Swap(List<T> elements, int firstIndex, int secondIndex)
        {
            T firstElement = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = firstElement;
        }
        public int CompareTo(T other)
        => Element.CompareTo(other);
        public int Count<T>(List<T> list, T readLine) where T : IComparable => list.Count(word => word.CompareTo(readLine) > 0);  
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            //return $"{typeof(T)}: {Element}";
            return sb.ToString().Trim();
        }     
    }
}
