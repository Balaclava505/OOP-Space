using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    public interface ISpaceSerializer
    {
        void Serialize(Star value, string path);

        object Deserialize(Type value, string path);

    }
}
