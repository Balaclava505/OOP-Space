using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    public class Planet : OrbitalObject
    {

        public Star star; 
        public List<Planet> planets;
        //public List<Satellite> satellites;
        public Planet planet;
        //public Satellite satellite; //
        public int num;
        int prevDist = 50;

        public List<Satellite> satellites = new List<Satellite>();
        

        Random random = new Random();

        // public List<Planet> planets;
        // public bool HasCircle { get; set; }
        // public string Chemistry { get; set; }
        

        public Planet(int name, int radius, double x, double y, Color color, double ang, int dist, double speed) :base(name, radius, x, y, color, ang, dist, speed)
        {
        }

        public List<Satellite> CreateRandPlanet(int total, int level, List<Planet> planets)
        {
            Satellite satellite = new Satellite(0, 0, 0, 0, RandomColor(), 0, 0, 0,0);
            satellites.Add(satellite);
            int name = 1;
            for (int i = 0; i < total; i++)
            {               
                InitData(name, level, planets);
                if (level < 3)
                {
                    num = random.Next(0, 4);
                    satellite.CreateRandSat(num, level + 1, satellites, name);
                }
                name++;
            }
            return satellites;
        }

        public void InitData(int name, int level, List<Planet> planets)
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

            planets.Add(new Planet(name, rad, x, y, RandomColor(), ang, dist, speed));
        }

        public void Move(List<Planet> planets, List<Satellite> satellites, Star star)
        {
            foreach (Planet planet in planets)
            {
                planet.X = (float)(planet.Distance * Math.Cos(planet.Angle)) + star.X + (star.Radius/1.41); //Уравнения эллипса в параметрической форме
                planet.Y = (float)(planet.Distance * Math.Sin(planet.Angle)) + star.Y + (star.Radius/1.41); 
                planet.Angle += planet.OrbitSpeed; //угол меняется при каждом тике таймера
                foreach (Satellite satellite in satellites)
                {
                    if (satellite.fatherName == planet.Name)
                    {
                        satellite.X = (float)(satellite.Distance * Math.Cos(satellite.Angle)) + planet.X + (planet.Radius / 1.41); 
                        satellite.Y = (float)(satellite.Distance * Math.Sin(satellite.Angle)) + planet.Y + (planet.Radius / 1.41);
                        satellite.Angle += satellite.OrbitSpeed; 
                    }
                }
            }

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
