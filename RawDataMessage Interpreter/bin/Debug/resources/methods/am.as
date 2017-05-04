var _loc_9:* = 0;
        var _loc_10:* = 0;
        var _loc_11:* = 0;
        var _loc_7:* = param2 & 32767;
        var _loc_8:* = param2 >> 15;
        do
        {
            
            _loc_9 = this.a[param1] & 32767;
            _loc_10 = this.a[param1++] >> 15;
            _loc_11 = _loc_8 * _loc_9 + _loc_10 * _loc_7;
            _loc_9 = _loc_7 * _loc_9 + ((_loc_11 & 32767) << 15) + param3.a[param4] + (param5 & 1073741823);
            param5 = (_loc_9 >>> 30) + (_loc_11 >>> 15) + _loc_8 * _loc_10 + (param5 >>> 30);
            param4 = param4++;
            param3.a[param4] = _loc_9 & 1073741823;
            param6 = (param6 - 1);
        }while (param6 >= 0)
        return param5;
    