using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CircleMovement
{
    public abstract class SpaceObject
    {
        
        public double X { get; set; } 
        public double Y { get; set; } 
        public Color ColorObj { get; set; }

        public SpaceObject(double x, double y, Color col)
        {
            X = x;
            Y = y;
            ColorObj = col;
        }    
    }


}
