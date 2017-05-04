param2 = param2 - 1;
        var _loc_5:* = this.t + param1.t - param2;
        param3.t = this.t + param1.t - param2;
        var _loc_4:* = _loc_5;
        param3.s = 0;
        while (--_loc_4 >= 0)
        {
            
            param3.a[_loc_4] = 0;
        }
        --_loc_4 = Math.max(param2 - this.t, 0);
        while (_loc_4 < param1.t)
        {
            
            param3.a[this.t + --_loc_4 - param2] = this.am(param2 - _loc_4, param1.a[_loc_4], param3, 0, 0, this.t + _loc_4 - param2);
            _loc_4++;
        }
        param3.clamp();
        param3.drShiftTo(1, param3);
        return;
    