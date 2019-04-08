using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace CircleMovement
{
    [Serializable]
    public class Star : SpaceObject
    {
        public int Radius { get; set; }
        public int CountPlan { get; set; }

        public List<Planet> planets = new List<Planet>();
        public List<Satellite> satellites = new List<Satellite>();
        public Rocket rocket;

        public Star() : base()
        {
        }

        public Star(Rocket rock,int radius, double x, double y, Color color, int count) : base(x,y, color)
        {
            CountPlan = count;
            Radius = radius;
            rocket = rock;
        }

        public Star(Dictionary<string, string> info, string object_name) : base(info, object_name)
        {
            int CountSat = 0;
            CountPlan = int.Parse(info["Number of planets"]);
            Radius = int.Parse(info["Star Radius"]);
            rocket = new Rocket(info);
            for (int j = 1; j <= CountPlan; j++)
            {
                planets.Add(new Planet(info, "Planet" + j.ToString()));
            }
            foreach (Planet planet in planets)
                CountSat += planet.CountSat;

            for (int j = 1; j <= CountSat; j++)
            {
                satellites.Add(new Satellite(info, "Satellite" + j.ToString()));
            }
        }

        public override void GetObjectData(Dictionary<string,object> info, string object_name)
        {
            int i = 1;
            int j = 1;
            base.GetObjectData(info, object_name);
            info.Add("Number of planets: ", CountPlan);
            info.Add("Star Radius: ", Radius);
            //info.Add("Rocket: ", rocket);
            rocket.GetObjectData(info);
            foreach (Planet planet in planets)
            {
                //info.Add("Planet" + i.ToString() + ": ", planet);
                planet.GetObjectData(info, "Planet" + i.ToString());
                i++;
            }
            foreach (Satellite satellite in satellites)
            {
                //info.Add("Satellite" + i.ToString() + ": ", satellite);
                satellite.GetObjectData(info, "Satellite" + j.ToString());
                j++;
            }
        }

        public void CreateSystem()
        {            
            Planet planet = new Planet();
            //planets.Add(planet);
            satellites = planet.CreateRandPlanetAndSat(CountPlan, planets);
        }

        public void Shine(Graphics g)
        {
            Pen StarColor = new Pen(ColorObj);
            Random R = new Random();
            int TLX = (int)X + Radius ;
            int TLY = (int)Y + Radius;
            int X_coord = 0; 
            int Y_coord = 0; 
            for (float I = 0; I <= 360; I += 0.9F) 
            {
                X_coord = Convert.ToInt32(Math.Cos(I) * 7 * R.Next(0, 6) + TLX); 
                Y_coord = Convert.ToInt32(Math.Sin(I) * 7 * R.Next(0, 6) + TLY); 
                g.DrawLine(StarColor, X_coord, Y_coord, TLX, TLY); 
            }
        }

    }
}
