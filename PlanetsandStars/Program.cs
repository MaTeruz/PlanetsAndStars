using System;
using System.Collections.Generic;
using System.Collections;

namespace PlanetsandStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of all the planet in our solar system
            List<Planet> planets = new List<Planet>();

            //list of planets with mean temp under 0
            List<Planet> planet_Mtemp = new List<Planet>();

            //list of planets with a diameter of 10,000 to 50,000
            List<Planet> planetDim = new List<Planet>();


            //here im using my constructor to create new planets to add to my list's
            Planet jorden = new Planet("Jorden", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "no");
            Planet merkur = new Planet("Merkur", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "no");
            Planet venus = new Planet("Venus", 4.87, 12104, 5243, 3.7, -5832.5, 2802.0, 1082, 224.7, 35.0, 464, 0, "no");
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "no");
            Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, "yes");
            Planet jupitor = new Planet("Jupitor", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "yes");
            Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, "yes");
            Planet neptune = new Planet("Neptun", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 598, 5.4, -200, 14, "yes" );
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 9056, 4.7, -225, 5, "no");
            
            //here im adding my planets to my main list of planets
            planets.Add(merkur);
            planets.Add(jorden);
            planets.Add(venus);
            planets.Add(mars);
            planets.Add(saturn);
            planets.Add(jupitor);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            //And here im adding my mean temp planets under 0
            planet_Mtemp.Add(mars);
            planet_Mtemp.Add(saturn);
            planet_Mtemp.Add(jupitor);
            planet_Mtemp.Add(uranus);
            planet_Mtemp.Add(neptune);
            planet_Mtemp.Add(pluto);

            //This is where im adding the planets to the new list 
            planetDim.Add(jorden);
            planetDim.Add(venus);
            planetDim.Add(neptune);

            //this is how im counting the elements in my list
            Console.WriteLine("lits of all planets");
            Console.WriteLine("\nCapacity {0}", planets.Count);
            Console.WriteLine();
            Console.WriteLine();

            //here im printing my first list
            foreach (Planet planet in planets)
            {
                planet.Print();
                Console.WriteLine();
            }
               
            //Removing plute at position 8
            planets.RemoveAt(8);
            Console.WriteLine();
            Console.WriteLine("\nNew Capacity {0}", planets.Count);
            Console.WriteLine();

            foreach (Planet planet in planets)
            {
                planet.Print();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("List of planets with mean temp");
            Console.WriteLine("\nCapacity {0}", planet_Mtemp.Count);
            Console.WriteLine();

            foreach (Planet Planet in planet_Mtemp) 
            {
                Planet.Print();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("list of planets with the diameter of 10,000km to 50,000km");
            Console.WriteLine("\nCapacity {0}", planetDim.Count);
            Console.WriteLine();

            foreach (Planet planet in planetDim)
            {
                planet.Print();
                Console.WriteLine();
            }

            //A for loop that deletes my list of planets with diameter 10k to 50k
            for (int i = 0; i < planetDim.Count; i++)
            {
                planetDim.RemoveAt(0);
            }
            planetDim.Clear();

            //checing if the planets in the list is deleted correctly
            Console.WriteLine("\nPlanet with Diameter 10,000 to 50,000km Capacity {0}", planetDim.Count);


            Console.ReadKey();
        }
    }
}
