using IteratorCompositeLab.Components;
using IteratorCompositeLab.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Iterators
{
    class CompositeIterator : IIterator
    {
        private Composite composite;
        private int index;
        private IIterator currentIterator;

        public CompositeIterator(Composite composite)
        {
            this.composite = composite;
            if(composite.GetChildren().Count > 0)
            {
                this.currentIterator = composite.GetChildren()[0].GetIterator();
            }
        }
        public bool HasNext()
        {
            return this.index < composite.GetChildren().Count;
        }

        public IComponent Next()
        {
            if (this.currentIterator.HasNext())
            {
                IComponent leaf = this.currentIterator.Next();

                if (!this.currentIterator.HasNext())
                {
                    index++;
                    if (HasNext())
                    {
                        this.currentIterator = this.composite.GetChildren()[index].GetIterator();
                    }
                }
                return leaf;
            }
            else
            {
                IComponent leaf = this.composite.GetChildren()[index++];
                Console.WriteLine(leaf.GetQuestion().ToString());
                if (HasNext())
                {
                    this.currentIterator = this.composite.GetChildren()[index].GetIterator();
                }
                return leaf;
            }
        }
    }
}
