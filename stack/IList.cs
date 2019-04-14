using System;
using System.Collections.Generic;

namespace stack
{
    public interface IList<T> where T : IComparable
    {
        void AddElement(T value);
        bool FindValue(T value);
        void DeleteValue(T value);            
    }
}