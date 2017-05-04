var _loc_7:* = 0;
        param2.s = this.s;
        var _loc_3:* = param1 / DB;
        if (_loc_3 >= this.t)
        {
            param2.t = 0;
            return;
        }
        var _loc_4:* = param1 % DB;
        var _loc_5:* = DB - _loc_4;
        var _loc_6:* = (1 << _loc_4) - 1;
        param2.a[0] = this.a[_loc_3] >> _loc_4;
        _loc_7 = _loc_3 + 1;
        while (_loc_7 < this.t)
        {
            
            param2.a[_loc_7 - _loc_3 - 1] = param2.a[_loc_7 - _loc_3 - 1] | (this.a[_loc_7] & _loc_6) << _loc_5;
            param2.a[_loc_7 - _loc_3] = this.a[_loc_7] >> _loc_4;
            _loc_7++;
        }
        if (_loc_4 > 0)
        {
            param2.a[this.t - _loc_3 - 1] = param2.a[this.t - _loc_3 - 1] | (this.s & _loc_6) << _loc_5;
        }
        param2.t = this.t - _loc_3;
        param2.clamp();
        return;
    