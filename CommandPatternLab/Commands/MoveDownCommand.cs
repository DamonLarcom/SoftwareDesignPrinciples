using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab.Commands
{
    class MoveDownCommand : ICommand
    {
        private IReceiver receiver;

        public MoveDownCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.MoveDown();
        }

        public void Undo()
        {
            this.receiver.MoveUp();
        }
    }
}
