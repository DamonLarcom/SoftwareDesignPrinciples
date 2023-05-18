using FactoryPatternInClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternInClass.Objects
{
    class MiniAsteroid : Asteroid
    {
        public MiniAsteroid(int speed, int direction, int rotation)
            : base(speed, direction, rotation) { }

        public override void Move()
        {
            Console.WriteLine($"Mini Asteroid moving at speed {Speed}, direction {Direction}, and rotation {Rotation} degrees.");
        }
    }
}
