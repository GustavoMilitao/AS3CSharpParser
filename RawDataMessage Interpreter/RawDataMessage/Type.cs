using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public enum Type
    {
        RSAKey,
        BigInteger,
        AESKey,
        TLSPad,
        SimpleIVMode,
        CBCMode,
        Unknown
    }
}
