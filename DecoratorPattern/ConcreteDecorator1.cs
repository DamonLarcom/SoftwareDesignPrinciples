using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecorator1 : AbstractDecorator
    {
        public ConcreteDecorator1(IComponent component)
            : base(component) { }

        public override void Operation()
        {
            Console.WriteLine("I give you decoration!");
            base.Operation();
        }
    }
}
