using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab
{
    class Invoker
    {
        private ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }

        public void UndoCommand()
        {
            command.Undo();
        }
    }
}
