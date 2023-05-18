using IteratorCompositeLab.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Iterators
{
    class LeafIterator : IIterator
    {
        public bool HasNext()
        {
            return false;
        }

        public IComponent Next()
        {
            return null;
        }
    }
}
