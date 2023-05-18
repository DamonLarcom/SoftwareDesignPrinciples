using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("I am the concrete component");
        }
    }
}
