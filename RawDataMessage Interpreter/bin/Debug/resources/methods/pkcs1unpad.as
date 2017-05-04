var _loc_4:* = param1.toByteArray();
        var _loc_5:* = new ByteArray();
        _loc_4.position = 0;
        var _loc_6:* = 0;
        while (_loc_6 < _loc_4.length && _loc_4[_loc_6] == 0)
        {
            
            _loc_6++;
        }
        if (_loc_4.length - _loc_6 != (param2 - 1) || _loc_4[_loc_6] != param3)
        {
            return null;
        }
        _loc_6++;
        while (_loc_4[++_loc_6] != 0)
        {
            
            if (++_loc_6 >= _loc_4.length)
            {
                return null;
            }
        }
        while (++_loc_6 < _loc_4.length)
        {
            
            _loc_5.writeByte(_loc_4[_loc_6]);
        }
        _loc_5.position = 0;
        return _loc_5;
    