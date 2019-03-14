using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CircleMovement
{
    // Класс "Звезда"
    public class Star : SpaceObject
    {
        public int Radius { get; set; }

        public List<Planet> planets = new List<Planet>();
        public List<Satellite> satellites;
        // public Planet planet = new Planet(0,0,0,0,0,0);

        public Star(int radius, double x, double y, Color color) : base(x,y, color)
        {
            Radius = radius;
        }

        public void CreateSystem(out List<Planet> plan, out List<Satellite> sat)
        {            
            Planet planet = new Planet(0, 0, 0, 0, Color.Green, 0, 50, 0);
            planets.Add(planet);
            satellites = planet.CreateRandPlanet(3, 1, planets);
            plan = planets;
            sat = satellites;
        }

        public void Shine(Graphics g)
        {
            Pen StarColor = new Pen(ColorObj);
            Random R = new Random();
            int TL = (int)X + Radius ; 
            int X_coord = 0; 
            int Y_coord = 0; 
            for (float I = 0; I <= 360; I += 0.9F) 
            {
                X_coord = Convert.ToInt32(Math.Cos(I) * 7 * R.Next(0, 6) + TL); 
                Y_coord = Convert.ToInt32(Math.Sin(I) * 7 * R.Next(0, 6) + TL); 
                g.DrawLine(StarColor, X_coord, Y_coord, TL, TL); 
            }
        }

    }
}
