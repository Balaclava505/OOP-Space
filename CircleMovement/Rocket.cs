using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMovement
{
    public class Rocket
    {
        public Bitmap Img { get; set; }

        public Rocket(Bitmap img)
        {
            Img = img;
        }

        public void Fly(KeyEventArgs e, OrbitalObject rocket)
        {

            switch (e.KeyCode)
            {
                case Keys.Left: rocket.X -= 5; break;
                case Keys.Right: rocket.X += 5; break;
                case Keys.Down: rocket.Y += 5; break;
                case Keys.Up: rocket.Y -= 5; break;
            }

        }
    }
}
