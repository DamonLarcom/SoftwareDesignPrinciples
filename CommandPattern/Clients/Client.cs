using CommandPattern.Interfaces;
using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Clients
{
    public class Client
    {
        public static IReceiver getClient()
        {
            return new Receiver();
        }
    }
}
