using IteratorCompositeLab.Interfaces;
using IteratorCompositeLab.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Components
{
    class Leaf : IComponent
    {
        public Question question;

        public Leaf(Question question)
        {
            this.question = question;
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public IIterator GetIterator()
        {
            return new LeafIterator();
        }

        public Question GetQuestion()
        {
            return this.question;
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
