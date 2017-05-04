using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class CheckIntegrityMessage
    {
        public List<int> data;
        public  const uint protocolId = 6372;
        private bool _isInitialized = false;

        public CheckIntegrityMessage()
        {
            this.data = new List<int>();
        }

        public CheckIntegrityMessage initCheckIntegrityMessage(List<int> param1 = null)
        {
            this.data = param1;
            this._isInitialized = true;

            return this;
        }
    }
}
