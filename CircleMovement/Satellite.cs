using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    [Serializable]
    public class Satellite: OrbitalObject
    {
        public int fatherName { get; set; }

        public List<Satellite> satellites;

        public Satellite() : base() { }

        public Satellite(int name, int radius,double x, double y, Color color, double ang, int dist, int f_name, double speed)
         : base(name, radius,x,y, color, ang, dist, speed)
        {          
            fatherName = f_name;
        }

        public Satellite(Dictionary<string, string> info, string object_name) : base(info, object_name)
        {
            fatherName = int.Parse(info[object_name + " " + Name + " of planet with number"]);
        }

        Random random = new Random();
        public int NumOfSat = 1;

        public override void GetObjectData(Dictionary<string, object> info, string object_name)
        {
            base.GetObjectData(info, object_name);
            info.Add(object_name + " " + Name + " of planet with number: ", fatherName);
            NumOfSat++;
        }

        public void CreateRandSat(int num, int name, List<Satellite> satellites, int f_name)
        {
            int rad;
            int dist;
            int ang;
            int y;
            double x;
            double speed;
            for (int i = 0; i < num; i++)
            {
                rad = random.Next(1,5);
                ang = random.Next(360);
                speed = random.Next(3, 6);
                speed /= 10;
                dist = random.Next(23, 30);
                x = 0; y = 0;
                name++;
                satellites.Add(new Satellite(name, rad, x, y, RandomColor(), ang, dist, f_name, speed));
                
            }
        }

        public void Del(List<Satellite> satellites, int name)
        {
            foreach (Satellite satellite in satellites)
            {
                if (name == satellite.fatherName)
                {
                    satellites.Remove(satellite);
                    break;
                }
            }
        }

    }
}
