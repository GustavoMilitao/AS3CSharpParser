if (param1 == 0)
        {
            return -1;
        }
        var _loc_2:* = 0;
        if ((param1 & 65535) == 0)
        {
            param1 = param1 >> 16;
            _loc_2 = _loc_2 + 16;
        }
        if ((param1 & 255) == 0)
        {
            param1 = param1 >> 8;
            _loc_2 = _loc_2 + 8;
        }
        if ((param1 & 15) == 0)
        {
            param1 = param1 >> 4;
            _loc_2 = _loc_2 + 4;
        }
        if ((param1 & 3) == 0)
        {
            param1 = param1 >> 2;
            _loc_2 = _loc_2 + 2;
        }
        if ((param1 & 1) == 0)
        {
            _loc_2++;
        }
        return _loc_2;
    