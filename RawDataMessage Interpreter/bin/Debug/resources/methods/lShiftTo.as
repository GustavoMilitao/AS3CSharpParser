var _loc_8:* = 0;
        var _loc_3:* = param1 % DB;
        var _loc_4:* = DB - _loc_3;
        var _loc_5:* = (1 << _loc_4) - 1;
        var _loc_6:* = param1 / DB;
        var _loc_7:* = this.s << _loc_3 & DM;
        _loc_8 = this.t - 1;
        while (_loc_8 >= 0)
        {
            
            param2.a[_loc_8 + _loc_6 + 1] = this.a[_loc_8] >> _loc_4 | _loc_7;
            _loc_7 = (this.a[_loc_8] & _loc_5) << _loc_3;
            _loc_8 = _loc_8 - 1;
        }
        _loc_8 = _loc_6 - 1;
        while (_loc_8 >= 0)
        {
            
            param2.a[_loc_8] = 0;
            _loc_8 = _loc_8 - 1;
        }
        param2.a[_loc_6] = _loc_7;
        param2.t = this.t + _loc_6 + 1;
        param2.s = this.s;
        param2.clamp();
        return;
    