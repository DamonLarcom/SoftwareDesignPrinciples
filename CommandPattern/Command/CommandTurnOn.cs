using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    class CommandTurnOn : ICommand
    {
        private IReceiver receiver;

        public CommandTurnOn(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.TurnOn();
        }

        public void Undo()
        {
            this.receiver.TurnOff();
        }
    }
}
