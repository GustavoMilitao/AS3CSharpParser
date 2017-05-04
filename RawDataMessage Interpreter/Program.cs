using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RawDataMessage_Interpreter
{
    class Program
    {
        // 4 - _a_-_-__
        // 5 - _a_-_
        // 6 - _a_---

        static void Main(string[] args)
        {
            ////if (args.Length < 0)
            ////{
            ////    Console.WriteLine("Usage: RawDataMessage Interpreter.exe [file(.swf)]");
            ////}
            ////else
            ////{
            ////    if (!Java.Checker.IsJavaInstalled())
            ////    {
            ////        Console.WriteLine("Java n'est pas installé sur votre ordinateur!");
            ////        return;
            ////    }

            ////    string inputFile = @"resources\2017-02-23 14-07-46_RDM.swf";//args[0];
            ////    Swf swf = new Swf(inputFile);

            //RawDataMessage.RawDataMessage rawDataMessage = new RawDataMessage.RawDataMessage();
            //RawDataMessage.CheckIntegrityMessage checkIntegrityMessage = new RawDataMessage.CheckIntegrityMessage();
            //rawDataMessage.getCheckIntegrityMessage();

            //    //checkIntegrityMessage.initCheckIntegrityMessage(rawDataMessage.getCheckIntegrityMessage());
            //checkIntegrityMessage.data.ForEach(item => Console.Write(item + ","));
            ////}
            ////Console.Read();

            RawDataMessage.RawDataMessage.DirSearch(@"E:\Source\Repos\BlueSheep\BlueSheep\Common\Protocol\types");
        }
    }
}
