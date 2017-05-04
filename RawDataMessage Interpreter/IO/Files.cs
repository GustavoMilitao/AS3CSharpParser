using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.IO
{
    public class Files
    {

        public static List<string> GetFiles(string directory, string extension)
        {
            return Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories)
                .Where(file => new string[] { extension }
                .Contains(Path.GetExtension(file)))
                .ToList();
                
        }

    }
}
