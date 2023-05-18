using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab.Commands
{
    class MoveUpCommand : ICommand
    {
        private IReceiver receiver;

        public MoveUpCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.MoveUp();
        }

        public void Undo()
        {
            this.receiver.MoveDown();
        }
    }
}
