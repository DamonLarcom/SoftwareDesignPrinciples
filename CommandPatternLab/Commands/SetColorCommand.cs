using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace CommandPatternLab.Commands
{
    class SetColorCommand : ICommand
    {
        private IReceiver receiver;
        private Color prev;
        private Color newColor;
        
        public SetColorCommand(IReceiver receiver, Color newColor, Color prev)
        {
            this.receiver = receiver;
            this.newColor = newColor;
            this.prev = prev;
        }

        public void Execute()
        {
            if(Brushes.Red.Color == newColor)
            {
                this.receiver.SetRed();
            } else if(Brushes.Blue.Color == newColor)
            {
                this.receiver.SetBlue();
            } else if (Brushes.Green.Color == newColor)
            {
                this.receiver.SetGreen();
            }
        }

        public void Undo()
        {
            if (Brushes.Red.Color == prev)
            {
                this.receiver.SetRed();
            }
            else if (Brushes.Blue.Color == prev)
            {
                this.receiver.SetBlue();
            }
            else if (Brushes.Green.Color == prev)
            {
                this.receiver.SetGreen();
            }
        }
    }
}
