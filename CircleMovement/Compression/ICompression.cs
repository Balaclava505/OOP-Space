using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement.Compression
{
    public interface ICompression
    {
        string Name { get; }

        string Format { get; }

        void Compress(string inputFile, string outputFile);

        void Decompress(string inputFile, string outputFile);
    }
}
