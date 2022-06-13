using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Generic_Scale
{
    public  class GenericScale<T>
    {
        public bool AreEqual(T left, T right)
        {
            return left.Equals(right);
        }
    }
}
