using CommandPattern.Clients;
using CommandPattern.Command;
using CommandPattern.Interfaces;
using CommandPattern.Invokers;
using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Client(ask the client what its controlling)
            IReceiver receiver = Client.getClient();

            //create the commands the remote will execute on the receiver
            ICommand turnOnCommand = new CommandTurnOn(receiver);
            ICommand turnOffCommand = new CommandTurnOff(receiver);

            //create the invokers(button) that will invoke the commands
            Invoker invokeOff = new Invoker(turnOffCommand);
            Invoker invokeOn = new Invoker(turnOnCommand);

            //you can invoke commands to execute in realtime
            Console.WriteLine("--Invoke commands--");
            invokeOn.ExecuteCommand();
            invokeOff.ExecuteCommand();

            Console.WriteLine();
            Console.WriteLine("--Undo Commands--");
            invokeOn.UndoCommand();
            invokeOff.UndoCommand();

            //or queue up commands to execute on the device
            Console.WriteLine("--Command Queue--");
            List<Invoker> commandList = new List<Invoker>();
            commandList.Add(invokeOn);
            commandList.Add(invokeOn);
            commandList.Add(invokeOn);
            commandList.Add(invokeOff);
            commandList.Add(invokeOff);
            commandList.Add(invokeOff);
            commandList.Add(invokeOn);
            commandList.Add(invokeOff);

            foreach(Invoker i in commandList)
            {
                i.ExecuteCommand();
            }
            
            commandList[commandList.Count - 1].UndoCommand();
        }
    }
}
