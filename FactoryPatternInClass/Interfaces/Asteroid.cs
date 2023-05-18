using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternInClass.Interfaces
{
    public abstract class Asteroid
    {
        public int Speed { get; set; }
        public int Direction { get; set; }
        public int Rotation { get; set; }

        public Asteroid(int speed, int direction, int rotation)
        {
            this.Speed = speed;
            this.Direction = direction;
            this.Rotation = rotation;
        }

        public abstract void Move();
    }
}
