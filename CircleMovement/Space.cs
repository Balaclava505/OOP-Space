using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.Serialization;

namespace CircleMovement
{
    [Serializable]
    public abstract class SpaceObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        [XmlIgnore]
        public Color ColorObj { get; set; }

        [XmlElement("ColorObj")]
        public int BackColorAsArgb
        {
            get { return ColorObj.ToArgb(); }
            set { ColorObj = Color.FromArgb(value); }
        }

        public SpaceObject(double x, double y, Color col)
        {
            X = x;
            Y = y;
            ColorObj = col;
        }

        protected SpaceObject(Dictionary<string, string> info, string object_name)
        {
            X = Convert.ToDouble(info[object_name + " X"]);
            Y = Convert.ToDouble(info[object_name + " Y"]);
            ColorObj = ConvertToColor(info[object_name + " Color"]);
        }

        public SpaceObject()
        {
        }

        public virtual void GetObjectData(Dictionary<string, object> info, string object_name)
        {
            info.Add(object_name + " X: ", X);
            info.Add(object_name + " Y: ", Y);
            info.Add(object_name + " Color: ", ColorObj);
        }

        public Color ConvertToColor(string value)
        {
            if (!value.StartsWith(" Color")) return Color.Empty;
            for (int n = 0; n < value.Length; n++)
                if (value[n] == '[')
                    value = value.Substring(n + 1);
            for (int n = 0; n < value.Length; n++)
                if (value[n] == ']')
                    value = value.Substring(0, n);
            bool IsRed = false; bool IsGreen = false; bool IsBlue = false;
            string R = ""; string G = ""; string B = "";
            for (int n = 0; n < value.Length - 1; n++)
            {
                if (value[n] == 'R' & value[n + 1] == '=')
                {
                    IsRed = true;
                    n = n + 2;
                }
                else if (value[n] == 'G' & value[n + 1] == '=')
                {
                    IsGreen = true;
                    n = n + 2;
                }
                else if (value[n] == 'B' & value[n + 1] == '=')
                {
                    IsBlue = true;
                    n = n + 2;
                }
                if ((IsRed | IsGreen | IsBlue) && value[n] == ',')
                {
                    IsRed = false;
                    IsGreen = false;
                    IsBlue = false;
                }
                else if (IsRed)
                {
                    R += value[n];
                }
                else if (IsGreen)
                {
                    G += value[n];
                }
                else if (IsBlue)
                {
                    B += value[n];
                }
            }
            
            Color parseColor;
            if (R == "")
            {
                parseColor = Color.FromName(value);
            }
            else
            {
                B += value[value.Length - 1];
                byte Red = byte.Parse(R); byte Green = byte.Parse(G); byte Blue = byte.Parse(B);
                parseColor = Color.FromArgb(Red, Green, Blue);
            }
            return parseColor;
        }
    }
}
