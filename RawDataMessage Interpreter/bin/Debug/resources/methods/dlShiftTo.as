var _loc_3:* = 0;
        _loc_3 = this.t - 1;
        while (_loc_3 >= 0)
        {
            
            param2.a[_loc_3 + param1] = this.a[_loc_3];
            _loc_3 = _loc_3 - 1;
        }
        _loc_3 = param1 - 1;
        while (_loc_3 >= 0)
        {
            
            param2.a[_loc_3] = 0;
            _loc_3 = _loc_3 - 1;
        }
        param2.t = this.t + param1;
        param2.s = this.s;
        return;
    