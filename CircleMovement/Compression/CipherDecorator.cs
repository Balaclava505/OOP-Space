using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement.Compression
{
    public class CipherDecorator : Decorator
    {
        public override string Name => "Ciphered " + base.Name;

        public override string Format => base.Format + "Ci";

        public CipherDecorator(ICompression compressor) : base(compressor) { }

        byte[] key = Encoding.ASCII.GetBytes("Key");

        public override void Compress(string inputFile, string outputFile)
        {
            Cipher(inputFile);
            base.Compress(inputFile, outputFile);
        }

        public override void Decompress(string inputFile, string outputFile)
        {
            base.Decompress(inputFile, outputFile);
            DeCipher(outputFile);
        }

        private void Cipher(string inputFile)
        {
            byte[] bytes = File.ReadAllBytes(inputFile);
            RC4 encoder = new RC4(key);
            byte[] result = encoder.Encode(bytes, bytes.Length);

            File.WriteAllBytes(inputFile, result);
        }

        private void DeCipher(string outputFile)
        {
            byte[] bytes = File.ReadAllBytes(outputFile);

            RC4 decoder = new RC4(key);
            byte[] result = decoder.Decode(bytes, bytes.Length);

            File.WriteAllBytes(outputFile, result);
        }
    }
}
