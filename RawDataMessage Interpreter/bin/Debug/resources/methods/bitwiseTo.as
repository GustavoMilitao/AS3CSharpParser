var _loc_4:* = 0;
        var _loc_5:* = 0;
        var _loc_6:* = Math.min(param1.t, this.t);
        _loc_4 = 0;
        while (_loc_4 < _loc_6)
        {
            
            param3.a[_loc_4] = this.param2(this.a[_loc_4], param1.a[_loc_4]);
            _loc_4++;
        }
        if (param1.t < this.t)
        {
            _loc_5 = param1.s & DM;
            _loc_4 = _loc_6;
            while (_loc_4 < this.t)
            {
                
                param3.a[_loc_4] = this.param2(this.a[_loc_4], _loc_5);
                _loc_4++;
            }
            param3.t = this.t;
        }
        else
        {
            _loc_5 = this.s & DM;
            _loc_4 = _loc_6;
            while (_loc_4 < param1.t)
            {
                
                param3.a[_loc_4] = this.param2(_loc_5, param1.a[_loc_4]);
                _loc_4++;
            }
            param3.t = param1.t;
        }
        param3.s = this.param2(this.s, param1.s);
        param3.clamp();
        return;
    