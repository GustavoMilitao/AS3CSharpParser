var _loc_6:* = null;
        var _loc_2:* = this.s < 0 ? (this.negate()) : (this.clone());
        var _loc_3:* = param1.s < 0 ? (param1.negate()) : (param1.clone());
        if (_loc_2.compareTo(_loc_3) < 0)
        {
            _loc_6 = _loc_2;
            _loc_2 = _loc_3;
            _loc_3 = _loc_6;
        }
        var _loc_4:* = _loc_2.getLowestSetBit();
        var _loc_5:* = _loc_3.getLowestSetBit();
        if (_loc_3.getLowestSetBit() < 0)
        {
            return _loc_2;
        }
        if (_loc_4 < _loc_5)
        {
            _loc_5 = _loc_4;
        }
        if (_loc_5 > 0)
        {
            _loc_2.rShiftTo(_loc_5, _loc_2);
            _loc_3.rShiftTo(_loc_5, _loc_3);
        }
        while (_loc_2.sigNum() > 0)
        {
            
            var _loc_7:* = _loc_2.getLowestSetBit();
            _loc_4 = _loc_2.getLowestSetBit();
            if (_loc_7 > 0)
            {
                _loc_2.rShiftTo(_loc_4, _loc_2);
            }
            var _loc_7:* = _loc_3.getLowestSetBit();
            _loc_4 = _loc_3.getLowestSetBit();
            if (_loc_7 > 0)
            {
                _loc_3.rShiftTo(_loc_4, _loc_3);
            }
            if (_loc_2.compareTo(_loc_3) >= 0)
            {
                _loc_2.subTo(_loc_3, _loc_2);
                _loc_2.rShiftTo(1, _loc_2);
                continue;
            }
            _loc_3.subTo(_loc_2, _loc_3);
            _loc_3.rShiftTo(1, _loc_3);
        }
        if (_loc_5 > 0)
        {
            _loc_3.lShiftTo(_loc_5, _loc_3);
        }
        return _loc_3;
    