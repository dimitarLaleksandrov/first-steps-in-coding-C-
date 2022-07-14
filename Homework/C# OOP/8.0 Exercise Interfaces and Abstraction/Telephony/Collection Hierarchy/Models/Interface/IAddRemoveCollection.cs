using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interface
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
