using IteratorCompositeInClass.Interfaces;
using IteratorCompositeInClass.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeInClass.Components
{
    public class Leaf : IComponent
    {
        private string value;

        public Leaf(string value)
        {
            this.value = value;
        }
        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public IIterator GetIterator()
        {
            return new LeafIterator();
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
