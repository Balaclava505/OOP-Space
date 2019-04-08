using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    public interface ITextSerialization
    {
       
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
