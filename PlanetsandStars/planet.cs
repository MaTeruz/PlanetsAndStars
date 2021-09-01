using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsandStars
{
    public class Planet
    {
        //here is the string's to my constructor
        private string planets;
        private string name;   
        private double mass;
        private float diameter;
        private float density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private float meanTemp;
        private int numberOfMoons;
        private string ringSystem;

        public Planet(string planets) { this.planets = planets; }
        
        //this is my planet constructor
        public Planet(string _name, double _mass, float _diameter, float _density, double _gravity, double _rotationPeriod, double _lenghtOfDay, double _distaneFromSun, double _orbitalPeriod, double _orbitalVelocity, float _meanTemp, int _numberOfMoons, string _ringSystem)
        {
            this.name = _name;
            this.mass = _mass;
            this.diameter = _diameter;
            this.density = _density;
            this.gravity = _gravity;
            this.rotationPeriod = _rotationPeriod;
            this.lengthOfDay = _lenghtOfDay;
            this.distanceFromSun = _distaneFromSun;
            this.orbitalPeriod = _orbitalPeriod;
            this.orbitalVelocity = _orbitalVelocity;
            this.meanTemp = _meanTemp;
            this.numberOfMoons = _numberOfMoons;
            this.ringSystem = _ringSystem;
        }

        //here i made a print method to print my planets
        public void Print ()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("mass: " + mass);
            Console.WriteLine("diameter: " + diameter);
            Console.WriteLine("density: " + density);
            Console.WriteLine("gravity: " + gravity);
            Console.WriteLine("rotation period: " + rotationPeriod);
            Console.WriteLine("lenght of day: " + lengthOfDay);
            Console.WriteLine("distance from sun: " + distanceFromSun);
            Console.WriteLine("orbital period: " + orbitalPeriod);
            Console.WriteLine("orbital velocity: " + orbitalVelocity);
            Console.WriteLine("mean temp: " + meanTemp);
            Console.WriteLine("number of moons: " + numberOfMoons);
            Console.WriteLine("ring system: " + ringSystem);
        }

    }
}
