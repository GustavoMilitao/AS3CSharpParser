var _loc_5:* = 0;
        var _loc_4:* = Math.min(this.t + param1.t, param2);
        param3.s = 0;
        param3.t = _loc_4;
        while (--_loc_4 > 0)
        {
            
            param3.a[--_loc_4] = 0;
        }
        _loc_5 = param3.t - this.t;
        while (_loc_4 < _loc_5)
        {
            
            param3.a[_loc_4 + this.t] = this.am(0, param1.a[_loc_4], param3, _loc_4, 0, this.t);
            _loc_4++;
        }
        _loc_5 = Math.min(param1.t, param2);
        while (_loc_4 < _loc_5)
        {
            
            this.am(0, param1.a[_loc_4], param3, _loc_4, 0, param2 - _loc_4);
            _loc_4++;
        }
        param3.clamp();
        return;
    