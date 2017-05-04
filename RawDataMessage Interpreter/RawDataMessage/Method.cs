using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class Method
    {
        public string Name { get; set; }
        public List<Variable> Parameters { get; set; }
        public string Content { get; set; }
        public string Scope { get; set; }
        public string OverrideVirtual { get; set; }
        public string Static { get; set; }
        public string Ret { get; set; }
    }
}
