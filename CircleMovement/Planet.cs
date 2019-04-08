using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    [Serializable]
    public class Planet : OrbitalObject
    { 

        public List<Planet> planets;
        public int CountSat { get; set; }
        int prevDist = 50;

        public List<Satellite> satellites = new List<Satellite>();
        
        Random random = new Random();
        
        public Planet(int name, int radius, double x, double y, Color color, double ang, int dist, double speed, int count) :base(name, radius, x, y, color, ang, dist, speed)
        {
            CountSat = count;
        }

        public Planet() : base() { }

        public Planet(Dictionary<string, string> info, string object_name) : base(info, object_name)
        {
            CountSat = int.Parse(info[object_name + "Number of satellites"]);
        }

        public override void GetObjectData(Dictionary<string, object> info, string object_name)
        {
           // int i = 1;
            base.GetObjectData(info, object_name);
            info.Add(object_name + "Number of satellites: ", CountSat);
            
        }

        public List<Satellite> CreateRandPlanetAndSat(int total, List<Planet> planets)
        {
            Satellite satellite = new Satellite();
            //satellites.Add(satellite);
            int name = 1;
            for (int i = 0; i < total; i++)
            {                              
                CountSat = random.Next(0, 4);
                satellite.CreateRandSat(CountSat, 0, satellites, name);
                InitData(name, CountSat, planets);
                name++;
            }
            return satellites;
        }

        public void InitData(int name, int CountSat, List<Planet> planets)
        {
            int rad = random.Next(6,13);
            int ang = random.Next(360);
            double speed = random.Next(1, 2);
            speed /= 10;
            foreach (Planet planet in planets)
            {
                prevDist = (int)planet.Distance;
            }

            int dist = prevDist + random.Next(50, 70);
            prevDist = dist;
            int x = 0; int y = 0; 

            planets.Add(new Planet(name, rad, x, y, RandomColor(), ang, dist, speed, CountSat));
        }

        public void Del(List<Planet> planets, int name)
        {
            foreach (Planet planet in planets)
            {
                if (name == planet.Name)
                {
                    planets.Remove(planet);
                    break;
                }
            }
        }

    }
}
