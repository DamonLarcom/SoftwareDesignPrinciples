using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternLab.Commands
{
    class MoveLeftCommand : ICommand
    {
        private IReceiver receiver;

        public MoveLeftCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            this.receiver.MoveLeft();
        }

        public void Undo()
        {
            this.receiver.MoveRight();
        }
    }
}
