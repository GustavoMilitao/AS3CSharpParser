using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.Compress
{
    public class GZip
    {

        public static byte[] Compress(byte[] input)
        {
            using (MemoryStream memory = new MemoryStream())
            using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true))
            {
                gzip.Write(input, 0, input.Length);
                return memory.ToArray();
            }
        }

        public static byte[] Decompress(byte[] input)
        {
            using (GZipStream gzip = new GZipStream(new MemoryStream(input), CompressionMode.Decompress, true))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = gzip.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    } while (count > 0);
                    return memory.ToArray();
                }
            }
        }
    
    }
}
