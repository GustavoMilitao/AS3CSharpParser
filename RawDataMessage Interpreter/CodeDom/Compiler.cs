using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.CodeDom
{
    public class Compiler
    {

        public static object Compile(string code)
        {
            CodeDomProvider cpd = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("System.dll");
            cp.ReferencedAssemblies.Add("mscorlib.dll");
            cp.ReferencedAssemblies.Add("System.Core.dll");
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;
            CompilerResults cr = cpd.CompileAssemblyFromSource(cp, code);

            if (cr.Errors.HasErrors == true)
            {
                throw new Exception("Error ! ");
            }

            Assembly asm = cr.CompiledAssembly;
            Type type = asm.GetType("Bypass");
            MethodInfo method = type.GetMethod("GetCheckIntegrityMessage");
            object result = method.Invoke(null, BindingFlags.InvokeMethod,null,null, System.Globalization.CultureInfo.CurrentCulture);

            return result;
        }

    }
}
