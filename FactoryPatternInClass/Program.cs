using FactoryPatternInClass.Factories;
using FactoryPatternInClass.Interfaces;
using System;
using System.Collections.Generic;

namespace FactoryPatternInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asteroid> asteroids = new List<Asteroid>();
            IAsteroidFactory factory = new AsteroidFactory();

            Console.WriteLine("----- LEVEL ONE ASTEROID FIELD -----");
            asteroids.Add(factory.GetAsteroid(1,"large"));
            asteroids.Add(factory.GetAsteroid(1,"large"));
            asteroids.Add(factory.GetAsteroid(1,"large"));
            asteroids.Add(factory.GetAsteroid(1,"large"));
            asteroids.Add(factory.GetAsteroid(1,"large"));

            foreach(Asteroid a in asteroids)
            {
                a.Move();
            }

            asteroids.Clear();

            Console.WriteLine("----- LEVEL TWO ASTEROID FIELD -----");
            asteroids.Add(factory.GetAsteroid(2, "large"));
            asteroids.Add(factory.GetAsteroid(2, "medium"));
            asteroids.Add(factory.GetAsteroid(2, "medium"));
            asteroids.Add(factory.GetAsteroid(2, "large"));
            asteroids.Add(factory.GetAsteroid(2, "large"));


            foreach (Asteroid a in asteroids)
            {
                a.Move();
            }

            asteroids.Clear();
        }
    }
}
