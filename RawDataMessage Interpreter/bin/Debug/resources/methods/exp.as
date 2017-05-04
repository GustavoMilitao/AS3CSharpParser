var _loc_7:* = null;
        if (param1 > 4294967295 || param1 < 1)
        {
            return ONE;
        }
        var _loc_3:* = this.nbi();
        var _loc_4:* = this.nbi();
        var _loc_5:* = param2.convert(this);
        var _loc_6:* = this.nbits(param1) - 1;
        _loc_5.copyTo(_loc_3);
        while (--_loc_6 >= 0)
        {
            
            param2.sqrTo(_loc_3, _loc_4);
            if ((param1 & 1 << _loc_6) > 0)
            {
                param2.mulTo(_loc_4, _loc_5, _loc_3);
                continue;
            }
            _loc_7 = _loc_3;
            _loc_3 = _loc_4;
            _loc_4 = _loc_7;
        }
        return param2.revert(_loc_3);
    