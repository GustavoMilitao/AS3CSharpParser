var _loc_9:* = null;
        var _loc_10:* = null;
        if (param5 == null)
        {
            param5 = this.pkcs1pad;
        }
        if (param2.position >= param2.length)
        {
            param2.position = 0;
        }
        var _loc_7:* = this.getBlockSize();
        var _loc_8:* = param2.position + param4;
        while (param2.position < _loc_8)
        {
            
            _loc_9 = new BigInteger(this.param5(param2, _loc_8, _loc_7, param6), _loc_7, true);
            _loc_10 = this.param1(_loc_9);
            _loc_10.toArray(param3);
        }
        return;
    