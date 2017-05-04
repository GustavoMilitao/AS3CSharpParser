var _loc_9:* = null;
        var _loc_10:* = null;
        var _loc_11:* = null;
        if (param5 == null)
        {
            param5 = this.pkcs1unpad;
        }
        if (param2.position >= param2.length)
        {
            param2.position = 0;
        }
        var _loc_7:* = this.getBlockSize();
        var _loc_8:* = param2.position + param4;
        while (param2.position < _loc_8)
        {
            
            _loc_9 = new BigInteger(param2, _loc_7, true);
            _loc_10 = this.param1(_loc_9);
            _loc_11 = this.param5(_loc_10, _loc_7, param6);
            if (_loc_11 == null)
            {
                throw new Error("Decrypt error - padding function returned null!");
            }
            param3.writeBytes(_loc_11);
        }
        return;
    