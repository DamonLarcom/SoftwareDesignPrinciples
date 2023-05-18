using FactoryPatternInClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternInClass.Objects
{
    public class LargeAsteroid : Asteroid
    {
        public LargeAsteroid(int speed, int direction, int rotation) 
            : base(speed, direction, rotation){}

        public override void Move()
        {
            Console.WriteLine($"Large Asteroid moving at speed {Speed}, direction {Direction}, and rotation {Rotation} degrees.");
        }
    }
}
