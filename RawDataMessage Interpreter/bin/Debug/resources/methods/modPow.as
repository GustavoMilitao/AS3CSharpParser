var _loc_4:* = 0;
        var _loc_6:* = null;
        var _loc_12:* = 0;
        var _loc_15:* = null;
        var _loc_16:* = null;
        var _loc_3:* = param1.bitLength();
        var _loc_5:* = nbv(1);
        if (_loc_3 <= 0)
        {
            return _loc_5;
        }
        if (_loc_3 < 18)
        {
            _loc_4 = 1;
        }
        else if (_loc_3 < 48)
        {
            _loc_4 = 3;
        }
        else if (_loc_3 < 144)
        {
            _loc_4 = 4;
        }
        else if (_loc_3 < 768)
        {
            _loc_4 = 5;
        }
        else
        {
            _loc_4 = 6;
        }
        if (_loc_3 < 8)
        {
            _loc_6 = new ClassicReduction(param2);
        }
        else if (param2.isEven())
        {
            _loc_6 = new BarrettReduction(param2);
        }
        else
        {
            _loc_6 = new MontgomeryReduction(param2);
        }
        var _loc_7:* = [];
        var _loc_8:* = 3;
        var _loc_9:* = _loc_4 - 1;
        var _loc_10:* = (1 << _loc_4) - 1;
        _loc_7[1] = _loc_6.convert(this);
        if (_loc_4 > 1)
        {
            _loc_16 = new BigInteger();
            _loc_6.sqrTo(_loc_7[1], _loc_16);
            while (_loc_8 <= _loc_10)
            {
                
                _loc_7[_loc_8] = new BigInteger();
                _loc_6.mulTo(_loc_16, _loc_7[_loc_8 - 2], _loc_7[_loc_8]);
                _loc_8 = _loc_8 + 2;
            }
        }
        var _loc_11:* = param1.t - 1;
        var _loc_13:* = true;
        var _loc_14:* = new BigInteger();
        _loc_3 = this.nbits(param1.a[_loc_11]) - 1;
        while (_loc_11 >= 0)
        {
            
            if (_loc_3 >= _loc_9)
            {
                _loc_12 = param1.a[_loc_11] >> _loc_3 - _loc_9 & _loc_10;
            }
            else
            {
                _loc_12 = (param1.a[_loc_11] & (1 << (_loc_3 + 1)) - 1) << _loc_9 - _loc_3;
                if (_loc_11 > 0)
                {
                    _loc_12 = _loc_12 | param1.a[(_loc_11 - 1)] >> DB + _loc_3 - _loc_9;
                }
            }
            _loc_8 = _loc_4;
            while ((_loc_12 & 1) == 0)
            {
                
                _loc_12 = _loc_12 >> 1;
                _loc_8 = _loc_8 - 1;
            }
            var _loc_17:* = _loc_3 - _loc_8;
            _loc_3 = _loc_3 - _loc_8;
            if (_loc_17 < 0)
            {
                _loc_3 = _loc_3 + DB;
                _loc_11 = _loc_11 - 1;
            }
            if (_loc_13)
            {
                _loc_7[_loc_12].copyTo(_loc_5);
                _loc_13 = false;
            }
            else
            {
                while (_loc_8 > 1)
                {
                    
                    _loc_6.sqrTo(_loc_5, _loc_14);
                    _loc_6.sqrTo(_loc_14, _loc_5);
                    _loc_8 = _loc_8 - 2;
                }
                if (_loc_8 > 0)
                {
                    _loc_6.sqrTo(_loc_5, _loc_14);
                }
                else
                {
                    _loc_15 = _loc_5;
                    _loc_5 = _loc_14;
                    _loc_14 = _loc_15;
                }
                _loc_6.mulTo(_loc_14, _loc_7[_loc_12], _loc_5);
            }
            while (_loc_11 >= 0 && (param1.a[_loc_11] & 1 << --_loc_3) == 0)
            {
                
                _loc_6.sqrTo(_loc_5, _loc_14);
                _loc_15 = _loc_5;
                _loc_5 = _loc_14;
                _loc_14 = _loc_15;
                if (--_loc_3 < 0)
                {
                    --_loc_3 = DB - 1;
                    _loc_11 = _loc_11 - 1;
                }
            }
        }
        return _loc_6.revert(_loc_5);
    