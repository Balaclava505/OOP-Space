using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement.Compression
{
    public abstract class Decorator : ICompression
    {
        public virtual string Name
        {
            get
            {
                return compressor.Name;
            }
        }

        public virtual string Format
        {
            get
            {
                return compressor.Format;
            }
        }

        protected ICompression compressor;

        protected Decorator(ICompression compressor)
        {
            this.compressor = compressor;
        }

        public virtual void Compress(string inputFile, string outputFile)
        {
            compressor.Compress(inputFile, outputFile);
        }

        public virtual void Decompress(string inputFile, string outputFile)
        {
            compressor.Decompress(inputFile, outputFile);
        }
    }
}
