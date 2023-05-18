using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab.Commands
{
    class MoveRightCommand : ICommand
    {
        private IReceiver receiver;

        public MoveRightCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            this.receiver.MoveRight();
        }

        public void Undo()
        {
            this.receiver.MoveLeft();
        }
    }
}
