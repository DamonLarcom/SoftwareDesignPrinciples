using IteratorCompositeInClass.Components;
using IteratorCompositeInClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeInClass.Iterators
{
    class CompositeIterator : IIterator
    {
        private Composite composite;
        private int index;
        private IIterator currentIterator;

        public CompositeIterator(Composite composite)
        {
            this.composite = composite;
            this.currentIterator = composite.GetChildren()[0].GetIterator();
        }
        public bool HasNext()
        {
            return this.index < composite.GetChildren().Count;
        }

        public IComponent Next()
        {
            if (this.currentIterator.HasNext())
            {
                //this is a composite
                //recursively move through the child category
                //returns any leafs (questions) on this node
                IComponent leaf = this.currentIterator.Next();

                if(!this.currentIterator.HasNext())
                {
                    index++;
                    if(HasNext())
                    {
                        //category has more nodes
                        // get the next iterator on this node
                        this.currentIterator = this.composite.GetChildren()[index].GetIterator();
                    }
                }
                return leaf;
            } else
            {
                //gets here only if there is no children left
                IComponent leaf = this.composite.GetChildren()[index++];
                if(HasNext())
                {
                    //this category has more nodes
                    this.currentIterator = this.composite.GetChildren()[index].GetIterator();
                }
                return leaf;
            }
        }
    }
}
