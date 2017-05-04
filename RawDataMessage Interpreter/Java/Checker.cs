using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.Java
{
    public class Checker
    {

        public static bool IsJavaInstalled()
        {
            bool installed = false;

            Process process = new Process();
            try
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.Arguments = "/c \"" + "java -version " + "\"";

                process.Start();
                process.WaitForExit();

                installed = process.ExitCode == 0;
            }
            catch { }

            return installed;
        }

    }
}
