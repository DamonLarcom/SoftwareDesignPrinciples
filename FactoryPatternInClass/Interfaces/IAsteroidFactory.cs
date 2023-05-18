using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternInClass.Interfaces
{
    public interface IAsteroidFactory
    {
        public Asteroid GetAsteroid(int level, string type);
    }
}
