using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interface
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        int Use { get;}
    }
}
