using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class AbstractDecorator : IComponent
    {
        private IComponent component;

        public AbstractDecorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            this.component.Operation();
        }
    }
}