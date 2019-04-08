using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMovement
{
    [Serializable]
    public class OrbitalObject : SpaceObject
    {
        public int Radius { get; set; }
        public double Angle { get; set; }
        public double Distance { get; set; }
        public double OrbitSpeed { get; set; }
        public int Name { get; set; }

        public Rocket rocket;

        Random rnd = new Random();

        public OrbitalObject() : base() { }

        public OrbitalObject(int name, int radius, double x, double y, Color color, double ang, int dist, double speed)
            : base(x, y, color)
        {
            Name = name;
            Radius = radius;
            Distance = dist;
            Angle = ang;
            OrbitSpeed = speed;
        }

        public OrbitalObject(double x, double y, Color color) : base(x, y, color)
        {
        }

        public OrbitalObject(Dictionary<string, string> info, string object_name) : base(info, object_name)
        {
            Name = int.Parse(info[object_name + " Number"]);
            Radius = int.Parse(info[object_name + " Radius"]);
            Distance = Convert.ToDouble(info[object_name + " Distance"]);
            Angle = Convert.ToDouble(info[object_name + " Angle"]);
            OrbitSpeed = Convert.ToDouble(info[object_name + " Orbit Speed"]);
        }

        public override void GetObjectData(Dictionary<string, object> info, string object_name)
        {
            base.GetObjectData(info, object_name);
            info.Add(object_name + " Number: ", Name);
            info.Add(object_name + " Radius: ", Radius);
            info.Add(object_name + " Distance: ", Distance);
            info.Add(object_name + " Angle: ", Angle);
            info.Add(object_name + " Orbit Speed: ", OrbitSpeed);
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

        public void Move(List<Planet> planets, List<Satellite> satellites, Star star)
        {
            foreach (Planet planet in planets)
            {
                planet.X = (float)(planet.Distance * Math.Cos(planet.Angle)) + star.X + (star.Radius / 1.41); //Уравнения эллипса в параметрической форме
                planet.Y = (float)(planet.Distance * Math.Sin(planet.Angle)) + star.Y + (star.Radius / 1.41);
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

    }

}
