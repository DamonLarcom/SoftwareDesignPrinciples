using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Interfaces
{
    public interface IReceiver
    {
        public void TurnOn();
        public void TurnOff();
    }
}
