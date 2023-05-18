using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command
{
    public class CommandTurnOff : ICommand
    {
        private IReceiver receiver;

        public CommandTurnOff(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.TurnOff();
        }

        public void Undo()
        {
            this.receiver.TurnOn();
        }
    }
}
