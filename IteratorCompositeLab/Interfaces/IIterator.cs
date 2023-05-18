using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Interfaces
{
    public interface IIterator
    {
        public bool HasNext();
        public IComponent Next();
    }
}
