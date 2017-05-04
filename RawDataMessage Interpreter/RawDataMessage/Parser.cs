using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class Parser
    {

        public static Type identifyType(string content)
        {
            string line = new StringReader(content).ReadLine();
            if (content.Contains("e:int") && content.Contains("n:BigInteger") && content.Contains("d:BigInteger") && content.Contains("p:BigInteger")
                && content.Contains("q:BigInteger") && content.Contains("dmp1:BigInteger") && content.Contains("dmq1:BigInteger") && content.Contains("pkcs1pad"))
            {
                return Type.RSAKey;
            }
            else if (line.Contains("BigInteger") && content.Contains("modPowInt"))
            {
                return Type.BigInteger;
            }
            else if (line.Contains("implements ISymmetricKey") && content.Contains("_Sbox"))
            {
                return Type.AESKey;
            }
            else if (line.Contains("implements IPad") && content.Contains("pad"))
            {
                return Type.TLSPad;
            }
            else if (line.Contains("implements IMode, ICipher") && content.Contains("IVMode"))
            {
                return Type.SimpleIVMode;
            }
            else if (line.Contains("extends IVMode implements IMode") && content.Contains("\"-cbc\""))
            {
                return Type.CBCMode;
            }
            return Type.Unknown;
        }

        public static string removeUselessThings(string content)
        {
            Regex regex = new Regex(@"if\(_loc[0-9]*_\)[\s\n]*{[\s\n]*}[\s\n]*");
            return regex.Replace(content, string.Empty);
        }

        public static List<Method> getMethods(string content)
        {
            //Regex regMethod = new Regex(@"(public|private|protected|)( static|) function (?<name>.*?)\((?<parameters>.*?)\) : (?<return>\w*\s*?){\s*(?<content>[\s\S]*?)}\/\/ end function");
            // Regex regMethod = new Regex(@"(public|private|protected|)( static|) function (?<name>.*?)\((?<parameters>.*?)\) : (?<return>\w*\s*?){\s*(?<content>[\s\S]*?)}\r\n\r\n");
            Regex regMethod = new Regex(@"(?<scope>public|private|protected|)(?<static> static|)(?<override> override| virtual|) function (?<name>.*?)\((?<parameters>.*?)\) : (?<return>\w*\s*?){\s*(?<content>[\s\S]*?)}[\s]*(private |public |}\r\n})");
            MatchCollection matches = regMethod.Matches(content);
            List<Method> methods = new List<Method>();

            foreach (Match match in matches)
            {
                Method method = new Method
                {
                    Name = match.Groups["name"].Value,
                    Ret = match.Groups["return"].Value,
                    Content = match.Groups["content"].Value, 
                    OverrideVirtual = match.Groups["override"].Value,
                    Scope = match.Groups["scope"].Value,
                    Static = match.Groups["static"].Value
                };

                method.Ret = !String.IsNullOrEmpty(method.Ret) ? method.Ret.Trim(): "void";

                StringReader reader = new StringReader(match.Value);
                string line = reader.ReadLine();
                if (line.Count(c => c == ':') > 1)
                {
                    string parameters = line.Split('(', ')')[1];
                    Regex regParameters = new Regex(@"(?<name>\w*\s*?):(?<type>\w*\s*)");
                    MatchCollection matchesParameters = regParameters.Matches(parameters);
                    List<Variable> variables = new List<Variable>();
                    Variable vars;
                    foreach (Match match_ in matchesParameters)
                    {
                        vars = new Variable
                        {
                            Name = match_.Groups["name"].Value,
                            Type = match_.Groups["type"].Value.Replace(" ", ""),
                        };
                        vars.Type = RawDataMessage.dictioVarTypes.ContainsKey(vars.Type) ?
                            RawDataMessage.dictioVarTypes[vars.Type] : vars.Type;
                        variables.Add(vars);
                    }
                    method.Parameters = variables;
                }
                methods.Add(method);
            }

            return methods;
        }


        public static List<Class> getClasses(string content)
        {
            List<Class> classes = new List<Class>();
            //Regex regClass = new Regex(@"(public |private |)class (?<name>\s*\w*?) extends (.*\w*\s*){\s*(?<content>[\s\S]*?)\w*}[\s\w]*\[\/CLASS\]", RegexOptions.None, Regex.InfiniteMatchTimeout);
            Regex regClass = new Regex(@"(?<scope>public|private|)(?<static>static|) class(?<name>\s*\w*?) (.*\w*\s*){\s*(?<content>[\s\S]*?)(}\/\/ end function[\s\w]*}|}[\s\w]*})");
            MatchCollection matchesClass = regClass.Matches(content);
            int count = matchesClass.Count;
            foreach (Match match in matchesClass)
            {
                Class clas = new Class
                {
                    Name = match.Groups["name"].Value,
                    Scope = match.Groups["scope"].Value,
                    Static = match.Groups["static"].Value
                };
                string content_ = match.Groups["content"].Value;
                clas.Methods = getMethods(content);
                clas.Variables = getVariables(content_);
                /*if (clas.Name == "HumanCheck")
                    clas.Methods = getMethods(content_);*/
                //clas.Type = identifyType(match.Value);
                //clas.Variables = getVariables(content_, true);
                classes.Add(clas);
            }

            return classes;
        }

        public static List<Variable> getVariables(string content, bool classVariables = true)
        {
            List<Variable> variables = new List<Variable>();
            Regex regVariable = new Regex(classVariables ? @"(?<scope>protected |public |private |)(?<static>static |)(var |)(?<const>const |)(?<name>\s*\w*?):(?<type>\s*\w*?)( = (?<value>.*?)|);"
                                                : @"var (?<name>\s*\w*?):(?<type>.*?)( = (?<value>.*?)|);");
            MatchCollection matches = regVariable.Matches(content);
            foreach (Match match in matches)
            {
                Variable variable = new Variable
                {
                    Name = match.Groups["name"].Value,
                    Type = match.Groups["type"].Value,
                    Value = match.Groups["value"].Value,
                    Static = match.Groups["static"].Value,
                    Scope = match.Groups["scope"].Value,
                    Const = match.Groups["const"].Value
                };

                variable.Type = RawDataMessage.dictioVarTypes.ContainsKey(variable.Type) ?
                    RawDataMessage.dictioVarTypes[variable.Type] : variable.Type;

                variables.Add(variable);
            }

            return variables;
        }
    }
}
