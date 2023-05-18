using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab.Interface
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
