var _loc_8:* = null;
        var _loc_9:* = 0;
        var _loc_5:* = new ByteArray();
        var _loc_6:* = param1.position;
        param2 = Math.min(param2, param1.length, _loc_6 + param3 - 11);
        param1.position = param2;
        var _loc_7:* = param2 - 1;
        while (_loc_7 >= _loc_6 && param3 > 11)
        {
            
            param3 = (param3 - 1);
            param3 = param3;
            _loc_5[param3] = param1[_loc_7--];
        }
        _loc_5[--_loc_3] = 0;
        if (param4 == 2)
        {
            _loc_8 = new Random();
            _loc_9 = 0;
            while (_loc_3 > 2)
            {
                
                do
                {
                    
                    _loc_9 = _loc_8.nextByte();
                }while (_loc_9 == 0)
                _loc_3 = --_loc_3 - 1;
                var _loc_11:* = --_loc_3 - 1;
                _loc_5[--_loc_3 - 1] = _loc_9;
            }
        }
        else
        {
            while (--_loc_3 > 2)
            {
                
                _loc_5[--_loc_3] = 255;
            }
        }
        _loc_5[--_loc_3] = param4;
        _loc_3 = --_loc_3 - 1;
        var _loc_12:* = --_loc_3 - 1;
        _loc_5[--_loc_3 - 1] = 0;
        return _loc_5;
    