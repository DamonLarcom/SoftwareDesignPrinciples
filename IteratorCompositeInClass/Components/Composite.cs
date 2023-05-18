using IteratorCompositeInClass.Interfaces;
using IteratorCompositeInClass.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeInClass.Components
{
    public class Composite : IComponent
    {
        private List<IComponent> children = new List<IComponent>();
        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public List<IComponent> GetChildren()
        {
            return this.children;
        }

        public IIterator GetIterator()
        {
            return new CompositeIterator(this);
        }

        public void Remove(IComponent component)
        {
            this.children.Remove(component);
        }
    }
}
