using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommandPatternLab.Interface
{
    interface IReceiver
    {
        public void MoveUp();
        public void MoveDown();
        public void MoveLeft();
        public void MoveRight();
        public void SetRed();
        public void SetBlue();
        public void SetGreen();
    }
}
