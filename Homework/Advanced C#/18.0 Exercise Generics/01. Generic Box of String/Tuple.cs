using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst firstElement, TSecond secondElement)
        {
            FIrstElement = firstElement;
            SecondElement = secondElement;
        }
        public TFirst FIrstElement { get; private set; }
        public TSecond SecondElement { get; private set; }
        public override string ToString()
        {
            return $"{FIrstElement} -> {SecondElement}";
        }
    }
}
