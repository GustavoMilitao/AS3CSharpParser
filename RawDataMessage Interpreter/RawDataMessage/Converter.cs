using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class Converter
    {

        private static string Convert(string code, RawDataMessage rdm)
        {
            StringReader reader = new StringReader(code);
            string positionChangedVar = "";
            string vectorIntVar = "";
            string line = "";
            string content = "";

            StringBuilder converted = new StringBuilder();
            List<Variable> variables = new List<Variable>();

            while ((line = reader.ReadLine()) != null)
            {
                Regex writeReg = new Regex(@"(?<name>\s*\w*?)\[""(?<todo>\s*\w*?)""\]\((?<value>\s*\w*.*)\)");

                var var = Parser.getVariables(line, false);
                Variable variable = new Variable();
                if (var.Count != 0)
                {
                    bool done = false;
                    variable = var[0];
                    if (variable.Value == "getDefinitionByName(\"com.ankamagames.dofus.network.messages.security::CheckIntegrityMessage\") as Class")
                    {
                        variable.Value = "new CheckIntegrityMessage()";
                    }
                    else if (variable.Value == "new getDefinitionByName(\"flash.utils.ByteArray\")()")
                    {
                        variable.Value = "new BinaryWriter(new MemoryStream(new byte[] {}))";
                    }
                    else if (variable.Value == "new Vector.<int>()")
                    {
                        variable.Value = "new List<int>()";
                        vectorIntVar = variable.Name;
                    }
                    try
                    {
                        Class clas = rdm.getClassByName(variable.Type);
                        //if (clas.Type == Type.TLSPad)
                        //{
                        //    done = true;
                        //}
                        //else if (clas.Type == Type.SimpleIVMode)
                        //{
                        //    done = true;
                        //}
                    }
                    catch { }
                    if (!line.Contains("_a_-_---") && !line.Contains("= getDefinitionByName") && !line.Contains("new _loc") && !line.Contains("new ByteArray") && !done) 
                    {
                        converted.AppendLine($"var {variable.Name} = {variable.Value};");
                        variables.Add(variable);
                    }
                }
                else if (line.Contains("open") && reader.ReadLine().Contains("readBytes") && reader.ReadLine().Contains("close"))
                {
                    converted.AppendLine($"string dofusInvokerMD5 = \"{System.Convert.ToBase64String(MD5(Properties.Resources.DofusInvoker))}\";");
                }
                else if (writeReg.IsMatch(line))
                {
                    Match match = writeReg.Match(line);
                    if (match.Groups["value"].Value.Contains("gameServerTicket"))
                    {
                        converted.AppendLine($"{match.Groups["name"].Value}.Write(gameServerTicket);");
                    }
                    else if (match.Groups["value"].Value.Contains("D5") && match.Groups["value"].Value.Contains("hash"))
                    {
                        converted.AppendLine($"{match.Groups["name"].Value}.Write(System.Convert.FromBase64String(dofusInvokerMD5));");
                        converted.AppendLine($"{match.Groups["name"].Value}.Close();");
                    }
                    else if (match.Groups["todo"].Value == "decrypt")
                    {
                        converted.AppendLine($"byte[] decrypted = DecryptAES(((MemoryStream){content}.BaseStream).ToArray(), ((MemoryStream){match.Groups["value"].Value}.BaseStream).ToArray());");
                        positionChangedVar = match.Groups["value"].Value;

                        converted.AppendLine("List<int> checkIntegrityMessage = ToListOf<int>(decrypted, BitConverter.ToInt32);");
                        converted.AppendLine("return checkIntegrityMessage;");
                        return converted.ToString();
                    }
                    else if (match.Groups["todo"].Value == "writeByte")
                    {
                        content = match.Groups["name"].Value;
                        converted.AppendLine($"{match.Groups["name"].Value}.Write((byte)({match.Groups["value"].Value.Replace("this.","")}));");
                    }
                }
            }

            return converted.ToString();
        }

        private static byte[] MD5(byte[] input)
        {
            return new MD5CryptoServiceProvider().ComputeHash(input);
        }

        private static string ConvertMethod(Method method)
        {
            StringBuilder converted = new StringBuilder();
            converted.AppendLine($"private static int {method.Name}(int param1, int param2 = 0)");
            converted.AppendLine("{");
            string tmp = method.Content.Replace(":*","");
            tmp = tmp.Replace("var", "int");
            converted.AppendLine(tmp);
            converted.AppendLine("return 0;");
            converted.AppendLine("}");
            converted.AppendLine();

            return converted.ToString();
        }

        private static string ConvertInit(string content, RawDataMessage rdm)
        {
            StringBuilder converted = new StringBuilder();
            StringReader reader = new StringReader(content);
            Regex regParse = new Regex(@"parseInt\((.*)\.(.*)\(-(?<value>[0-9]*?)\)\);");
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains("sendTicket"))
                    break;
                else if (line.Contains("this"))
                {
                    line = line.Replace("this.", "");
                    if (regParse.IsMatch(line))
                    {
                        Match match = regParse.Match(line);
                        int value = -System.Convert.ToInt32(match.Groups["value"].Value);
                        int q = System.Convert.ToInt32(Definition.First.GetDefinitionName(value, rdm.GetSwf().GetBinaryDatas()));
                        line = regParse.Replace(line, q.ToString()) + ";";
                    }
                    converted.AppendLine(line);
                }
            }

            return converted.ToString();
        }

        public static string GetFinalCode(RawDataMessage rdm)
        {
            Method method = rdm.getMethodByName("sendTicket");
            string converted = ConvertInit(rdm.GetSwf().GetActionScript()[0].Content, rdm)+ Convert(method.Content, rdm);

            StringBuilder variables = new StringBuilder();
            foreach(Variable variable in rdm.GetVariables())
            {
                if (variable.Name.StartsWith("_") && variable.Type == "int" && !variable.Name.Contains("loc"))
                {
                    variables.AppendLine($"private static int {variable.Name} = 0;");
                }
            }
            variables.AppendLine($"private static string gameServerTicket = \"{rdm.gameServerTicket}\";");

            StringBuilder methods = new StringBuilder();
            foreach (Method mthd in rdm.GetMethods())
            {
                if (mthd.Name.StartsWith("_") && mthd.Content.Contains("if(param2 == 0)") && mthd.Content.Contains("if(param2 == 3)"))
                {
                    methods.AppendLine(ConvertMethod(mthd));
                }
            }


            string template = Properties.Resources.Template;
            template = template.Replace("%variables%", variables.ToString());
            template = template.Replace("%methods%", methods.ToString());
            template = template.Replace("%code%", converted);

            return template;
        }

        public static string GetFinalCode(List<Class> classList, string nameSpace)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Join(" ", "namespace ", nameSpace, "{"));
            foreach (Class c in classList)
            {
                builder.Append(String.Join(" ", c.Scope, c.Static, "class", c.Name, "{"));
                string parameters = string.Empty;
                foreach(Variable v in c.Variables)
                {
                    if(!String.IsNullOrEmpty(v.Value))
                    {
                        v.Value = " = " + v.Value;
                    }
                    builder.Append(String.Join(" ", v.Scope, v.Static, v.Const, v.Type, v.Name, v.Value,";"));
                }
                foreach (Method m in c.Methods)
                {
                    if (m.Parameters != null)
                    {
                        parameters = String.Join(", ", m.Parameters.Select(item => item.Type + " " + item.Name).ToArray());
                    }
                    else
                    {
                        parameters = String.Empty;
                    }
                    builder.Append(String.Join(" ", m.Scope, m.Static, m.Ret, m.Name,"(", parameters, ")", "{"));
                    builder.Append(m.Content);
                    builder.Append("}");
                    builder.AppendLine();
                }
                builder.Append("}");
                builder.AppendLine();
            }
            builder.Append("}");
            return builder.ToString();
        }

    }
}