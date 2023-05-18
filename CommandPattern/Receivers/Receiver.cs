using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Receivers
{
    public class Receiver : IReceiver
    {
        public void TurnOff()
        {
            Console.WriteLine("Device is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Device is turned on.");
        }
    }
}
