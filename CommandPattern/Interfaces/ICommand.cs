using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        public void Execute();

        public void Undo();
    }
}
