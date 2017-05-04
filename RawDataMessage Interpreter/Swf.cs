using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter
{
    public class Swf
    {
        private string fileName = "";
        private List<AS> actionScripts;
        private List<byte[]> binaryDatas;

        public Swf(string fileName)
        {
            actionScripts = new List<AS>();
            binaryDatas = new List<byte[]>();
            this.fileName = fileName;

            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryName = RandomString(10);
            string directory = Path.Combine(currentDirectory, directoryName);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Extract SWF
            Java.Run.RunJar(fileName, directory);

            // Get AS
            var files = IO.Files.GetFiles(directory, ".as");
            foreach(var file in files)
            {
                AS actionScript = new AS
                {
                    FileName = file,
                    Content = File.ReadAllText(file)
                };
                actionScripts.Add(actionScript);
            }

            files = IO.Files.GetFiles(directory, ".bin");
            foreach(var file in files)
            {
                binaryDatas.Add(File.ReadAllBytes(file));
            }
            //Directory.Delete(directory, true);
        }

        public List<AS> GetActionScript()
        {
            return actionScripts;
        }

        public List<byte[]> GetBinaryDatas()
        {
            return binaryDatas;
        }

        private string RandomString(int length)
        {
            string pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder strBuilder = new StringBuilder();
            while (strBuilder.Length != length)
            {
                Random rnd = new Random();
                strBuilder.Append(pattern[rnd.Next(0, pattern.Length)]);
                Thread.Sleep(10);
            }

            return strBuilder.ToString();
        }
    }
}
