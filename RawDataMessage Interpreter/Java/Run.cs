using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.Java
{
    public class Run
    {
        public enum Mode
        {
            AS,
            BinaryData
        }


        public static void RunJar(string swfFileName, string outputDirectory)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = "ffdec.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Arguments = " -export as \"" + outputDirectory + "\" \"" + Path.GetFullPath(swfFileName) + "\"";

                process.Start();
                process.WaitForExit();

                process.StartInfo.Arguments = " -export binaryData \"" + outputDirectory + "\" \"" + Path.GetFullPath(swfFileName) + "\"";
                process.Start();
                process.WaitForExit();
            }
            catch { }
        }

    }
}
