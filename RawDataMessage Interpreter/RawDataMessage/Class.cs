    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class Class
    {
        public string Name { get; set; }
        public List<Method> Methods { get; set; }
        public List<Variable> Variables { get; set; }
        public string Scope { get; set; }
        public string Static { get; set; }
    }
}
