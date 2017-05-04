using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class Variable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Static { get; set; }
        public string Scope { get; set; }
        public string Const { get; set; }
    }
}
