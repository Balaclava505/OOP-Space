using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    class TextSerialization : ISpaceSerializer
    {

        public object Deserialize(Type objectType, string path)
        {
            Dictionary<string, string> SerialInfo = new Dictionary<string, string>();
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                stream.Seek(0, SeekOrigin.Begin);
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    string s;
                    while (!streamReader.EndOfStream)
                    {
                        s = streamReader.ReadLine();
                        string[] ss = s.Split(':');
                        ss[1].Trim();
                        SerialInfo.Add(ss[0], ss[1]);
                    }
                }
            }
            
            Star star = new Star(SerialInfo, "Star");
            return star;
        }

        public void Serialize(Star value, string path)
        {
            Dictionary<string, object> SerialInfo = new Dictionary<string, object>();
            //SerialInfo.Add("Star ", value);
            value.GetObjectData(SerialInfo, "Star");

            string[] infoStrArray = SerialInfo.Select(x => (x.Key + x.Value + "\r\n")).ToArray();           
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                int size;
                
                foreach (string s in infoStrArray)
                {
                    size = s.Length;
                    byte[] infoArray = new byte[size];
                    infoArray = System.Text.Encoding.UTF8.GetBytes(s);
                    stream.Write(infoArray, 0, infoArray.Length);
                }               
            }
        }

    }
}
