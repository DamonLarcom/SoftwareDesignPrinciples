using IteratorCompositeInClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeInClass.Iterators
{
    //null iterator
    public class LeafIterator : IIterator
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
