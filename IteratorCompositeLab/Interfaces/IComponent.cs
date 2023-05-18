using IteratorCompositeLab.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Interfaces
{
    public interface IComponent
    {
        public void Add(IComponent component);
        public void Remove(IComponent component);
        public IIterator GetIterator();

        public Question GetQuestion();
    }
}
