var _loc_2:* = param1.isEven();
        if (this.isEven() && _loc_2 || param1.sigNum() == 0)
        {
            return this.ZERO;
        }
        var _loc_3:* = param1.clone();
        var _loc_4:* = this.clone();
        var _loc_5:* = nbv(1);
        var _loc_6:* = nbv(0);
        var _loc_7:* = nbv(0);
        var _loc_8:* = nbv(1);
        while (_loc_3.sigNum() != 0)
        {
            
            while (_loc_3.isEven())
            {
                
                _loc_3.rShiftTo(1, _loc_3);
                if (_loc_2)
                {
                    if (!_loc_5.isEven() || !_loc_6.isEven())
                    {
                        _loc_5.addTo(this, _loc_5);
                        _loc_6.subTo(param1, _loc_6);
                    }
                    _loc_5.rShiftTo(1, _loc_5);
                }
                else if (!_loc_6.isEven())
                {
                    _loc_6.subTo(param1, _loc_6);
                }
                _loc_6.rShiftTo(1, _loc_6);
            }
            while (_loc_4.isEven())
            {
                
                _loc_4.rShiftTo(1, _loc_4);
                if (_loc_2)
                {
                    if (!_loc_7.isEven() || !_loc_8.isEven())
                    {
                        _loc_7.addTo(this, _loc_7);
                        _loc_8.subTo(param1, _loc_8);
                    }
                    _loc_7.rShiftTo(1, _loc_7);
                }
                else if (!_loc_8.isEven())
                {
                    _loc_8.subTo(param1, _loc_8);
                }
                _loc_8.rShiftTo(1, _loc_8);
            }
            if (_loc_3.compareTo(_loc_4) >= 0)
            {
                _loc_3.subTo(_loc_4, _loc_3);
                if (_loc_2)
                {
                    _loc_5.subTo(_loc_7, _loc_5);
                }
                _loc_6.subTo(_loc_8, _loc_6);
                continue;
            }
            _loc_4.subTo(_loc_3, _loc_4);
            if (_loc_2)
            {
                _loc_7.subTo(_loc_5, _loc_7);
            }
            _loc_8.subTo(_loc_6, _loc_8);
        }
        if (_loc_4.compareTo(this.ONE) != 0)
        {
            return this.ZERO;
        }
        if (_loc_8.compareTo(param1) >= 0)
        {
            return _loc_8.subtract(param1);
        }
        if (_loc_8.sigNum() < 0)
        {
            _loc_8.addTo(param1, _loc_8);
        }
        else
        {
            return _loc_8;
        }
        if (_loc_8.sigNum() < 0)
        {
            return _loc_8.add(param1);
        }
        return _loc_8;
    