using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    class BinarySerialization: ISpaceSerializer
    {
        public BinarySerialization()
        {
            formatter = new BinaryFormatter();
        }

        private BinaryFormatter formatter { get; set; }

        public object Deserialize(Type t, string path)
        {
            Star deserializeValue;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                deserializeValue = (Star)formatter.Deserialize(fs);
            }
            return deserializeValue;
        }

        public void Serialize(Star value, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, value);
            }

        }
    }
}
