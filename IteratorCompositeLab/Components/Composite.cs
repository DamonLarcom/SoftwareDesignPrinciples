using IteratorCompositeLab.Interfaces;
using IteratorCompositeLab.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Components
{
    public class Composite : IComponent
    {
        private List<IComponent> children = new List<IComponent>();

        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public IIterator GetIterator()
        {
            return new CompositeIterator(this);
        }

        public void Remove(IComponent component)
        {
            this.children.Remove(component);
        }

        public List<IComponent> GetChildren()
        {
            return this.children;
        }

        public Question GetQuestion()
        {
            return null;
        }
    }
}
