using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CircleMovement
{
    public class XmlSerialization : ISpaceSerializer
    {
        public object Deserialize(Type objectType, string path)
        {
            Star star = null;

            XmlSerializer xml = new XmlSerializer(objectType);
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                star = (Star)xml.Deserialize(stream);
            }                             
            return star;
        }

        public void Serialize(Star value, string path)
        {
            XmlSerializer xml = new XmlSerializer(value.GetType());
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(stream, value);
            }
        }
    }
}
