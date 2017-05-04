var _loc_3:* = 0;
        var _loc_2:* = 1;
        var _loc_4:* = param1 >>> 16;
        _loc_3 = param1 >>> 16;
        if (_loc_4 != 0)
        {
            param1 = _loc_3;
            _loc_2 = _loc_2 + 16;
        }
        var _loc_4:* = param1 >> 8;
        _loc_3 = param1 >> 8;
        if (_loc_4 != 0)
        {
            param1 = _loc_3;
            _loc_2 = _loc_2 + 8;
        }
        var _loc_4:* = param1 >> 4;
        _loc_3 = param1 >> 4;
        if (_loc_4 != 0)
        {
            param1 = _loc_3;
            _loc_2 = _loc_2 + 4;
        }
        var _loc_4:* = param1 >> 2;
        _loc_3 = param1 >> 2;
        if (_loc_4 != 0)
        {
            param1 = _loc_3;
            _loc_2 = _loc_2 + 2;
        }
        var _loc_4:* = param1 >> 1;
        _loc_3 = param1 >> 1;
        if (_loc_4 != 0)
        {
            param1 = _loc_3;
            _loc_2 = _loc_2 + 1;
        }
        return _loc_2;
    