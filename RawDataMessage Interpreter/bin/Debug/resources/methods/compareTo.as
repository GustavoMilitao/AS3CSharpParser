var _loc_2:* = this.s - param1.s;
        if (_loc_2 != 0)
        {
            return _loc_2;
        }
        var _loc_3:* = this.t;
        _loc_2 = _loc_3 - param1.t;
        if (_loc_2 != 0)
        {
            return _loc_2;
        }
        while (--_loc_3 >= 0)
        {
            
            _loc_2 = this.a[_loc_3] - param1.a[_loc_3];
            if (_loc_2 != 0)
            {
                return _loc_2;
            }
        }
        return 0;
    