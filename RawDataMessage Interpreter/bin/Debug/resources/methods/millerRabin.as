var _loc_7:* = null;
        var _loc_8:* = 0;
        var _loc_2:* = this.subtract(this.ONE);
        var _loc_3:* = _loc_2.getLowestSetBit();
        if (_loc_3 <= 0)
        {
            return false;
        }
        var _loc_4:* = _loc_2.shiftRight(_loc_3);
        param1 = (param1 + 1) >> 1;
        if (param1 > lowprimes.length)
        {
            param1 = lowprimes.length;
        }
        var _loc_5:* = new BigInteger();
        var _loc_6:* = 0;
        while (_loc_6 < param1)
        {
            
            _loc_5.fromInt(lowprimes[_loc_6]);
            _loc_7 = _loc_5.modPow(_loc_4, this);
            if (_loc_7.compareTo(this.ONE) != 0 && _loc_7.compareTo(_loc_2) != 0)
            {
                _loc_8 = 1;
                while (_loc_8++ < _loc_3 && _loc_7.compareTo(_loc_2) != 0)
                {
                    
                    _loc_7 = _loc_7.modPowInt(2, this);
                    if (_loc_7.compareTo(this.ONE) == 0)
                    {
                        return false;
                    }
                }
                if (_loc_7.compareTo(_loc_2) != 0)
                {
                    return false;
                }
            }
            _loc_6++;
        }
        return true;
    