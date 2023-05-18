using FactoryPatternInClass.Interfaces;
using FactoryPatternInClass.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternInClass.Factories
{
    class AsteroidFactory : IAsteroidFactory
    {
        public Asteroid GetAsteroid(int level, string type)
        {
            var randomGen = new Random();
            int speed = level * randomGen.Next(1, 3);
            if (speed > 10)
            {
                speed = 10;
            }
            int direction = randomGen.Next(1, 360);
            int rotation = randomGen.Next(1, 360);

            switch (type.ToLower())
            {
                case "mini":
                    return new MiniAsteroid(speed, direction, rotation);
                case "medium":
                    return new MediumAsteroid(speed, direction, rotation);
                case "large":
                    return new LargeAsteroid(speed, direction, rotation);
                default:
                    return null;
            }
        }
    }
}
