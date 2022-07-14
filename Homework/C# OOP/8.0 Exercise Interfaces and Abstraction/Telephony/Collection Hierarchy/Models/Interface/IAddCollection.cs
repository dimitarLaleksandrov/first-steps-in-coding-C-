using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interface
{
    public interface IAddCollection<T>
    {
        int Add(T item);
    }
}
