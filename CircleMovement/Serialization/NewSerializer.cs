using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    class NewSerializer
    { 

        public ISpaceSerializer GetfileName_Serialization(string fileName)
        {
            while (true) {
                string fileExtension = Path.GetExtension(fileName).TrimStart('.');
                if (fileExtension.StartsWith("xml"))
                    return new XmlSerialization();

                if (fileExtension.StartsWith("bin"))
                    return new BinarySerialization();

                if (fileExtension.StartsWith("txt"))
                    return new TextSerialization();
                fileName = fileName.TrimEnd(("." + fileExtension).ToCharArray());
            }
        }
    }
}
