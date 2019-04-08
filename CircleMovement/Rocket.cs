using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CircleMovement
{
    [Serializable]
    public class Rocket
    {
        [XmlIgnore]
        public Bitmap Img { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rocket() : base() { }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Img")]
        public byte[] ImgRocketSerialized
        {
            get
            { 
                Bitmap rocket_pict = new Bitmap(Properties.Resources.rocket, new Size(50, 50));
                if (Img == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    rocket_pict.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            set
            { 
                if (value == null)
                {
                    Img = null;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        Img = new Bitmap(ms);
                    }
                }
            }
        }

        public Rocket(Bitmap img, double x, double y)
        {
            Img = img;
            X = x;
            Y = Y;
        }

        public Rocket(Dictionary<string, string> info)
        {
            X = Convert.ToDouble(info["Rocket X"]);
            Y = Convert.ToDouble(info["Rocket Y"]);
            Img = new Bitmap(Properties.Resources.rocket, new Size(50, 50)); 
        }

        public void Fly(KeyEventArgs e, Rocket rocket)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: rocket.X -= 5; break;
                case Keys.Right: rocket.X += 5; break;
                case Keys.Down: rocket.Y += 5; break;
                case Keys.Up: rocket.Y -= 5; break;
            }

        }

        public void GetObjectData(Dictionary<string, object> info)
        {
            info.Add("Rocket X: ", X);
            info.Add("Rocket Y: ", Y);
            info.Add("Img: ", Properties.Resources.rocket);
        }
    }
}
