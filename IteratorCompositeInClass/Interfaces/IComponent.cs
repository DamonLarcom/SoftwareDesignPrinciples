using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeInClass.Interfaces
{
    public interface IComponent
    {
        public IIterator GetIterator();
        public void Add(IComponent component);
        public void Remove(IComponent component);
    }
}
