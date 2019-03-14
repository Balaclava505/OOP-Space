using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMovement
{
    //Класс "Орбитальные объект"
    public class OrbitalObject : SpaceObject
    {
        public int Radius { get; set; }
        public double Angle { get; set; }
        public double Distance { get; set; }
        public double OrbitSpeed { get; set; }
        public int Name { get; set; }

        public Rocket rocket;

        Random rnd = new Random();

        public OrbitalObject(int name, int radius, double x, double y, Color color, double ang, int dist, double speed)
            : base(x, y, color)
        {
            Name = name;
            Radius = radius;
            Distance = dist;
            Angle = ang;
            OrbitSpeed = speed;
        }

        public OrbitalObject(Rocket rock, double x, double y, Color color):base(x,y, color)
        {
            rocket = rock;
        }

        public Color RandomColor()
        {            
            Color myRgbColor = new Color();
            int r = rnd.Next(255);
            int g = rnd.Next(255);
            int b = rnd.Next(255);
            myRgbColor = Color.FromArgb(r, g, b);
            return myRgbColor;
        }

    }

}
