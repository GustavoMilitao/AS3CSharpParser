using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class RawDataMessage
    {
        private Swf swf = null;
        private List<Class> classes;
        private List<Method> methods;
        private List<Variable> variables;
        public string gameServerTicket = "";

        public RawDataMessage(Swf swf)
        {
            this.swf = swf;
            classes = new List<Class>();
            methods = new List<Method>();
            variables = new List<Variable>();
        }

        public RawDataMessage()
        {
            classes = new List<Class>();
            methods = new List<Method>();
            variables = new List<Variable>();
        }

        public Swf GetSwf()
        {
            return swf;
        }

        public List<Method> GetMethods()
        {
            return methods;
        }

        public List<Variable> GetVariables()
        {
            return variables;
        }

        public static Dictionary<string, string> dictioVarTypes = new Dictionary<string, string>() {
                { "Vector","List" },
                { "Number", "double" },
                { "Array", "ArrayList" },
                { "Boolean", "bool" }
            };

        public List<int> getCheckIntegrityMessage()
        {
            // Initialize
            StreamReader sr = new StreamReader(@"D:\DI\Dofus Invoker\types\game\character\characteristic\CharacterCharacteristicsInformations.as");
            AS humanCheck = new AS();
            humanCheck.Content = sr.ReadToEnd();
            humanCheck.FileName = "CharacterCharacteristicsInformations";
            //humanCheck.Content = Parser.removeUselessThings(humanCheck.Content);
            //StreamWriter writer = new StreamWriter(humanCheck.FileName + ".cleaned.as");
            //writer.Write(humanCheck.Content);
            //writer.Close();
            classes.AddRange(Parser.getClasses(humanCheck.Content));
            //methods.AddRange(Parser.getMethods(humanCheck.Content));
            //variables.AddRange(Parser.getVariables(humanCheck.Content));

            string converted = Converter.GetFinalCode(classes);
            File.WriteAllText("converted.cs", converted);

            string directory = Path.GetDirectoryName(swf.GetActionScript()[0].FileName);
            Directory.Delete(directory, true);

            return CodeDom.Compiler.Compile(converted) as List<int>;
        }

        public Class getClassByName(string name)
        {
            return this.classes.First(clas => clas.Name == name);
        }

        public Method getMethodByName(string name)
        {
            return methods.First(method => method.Name == name);
        }
    }
}
