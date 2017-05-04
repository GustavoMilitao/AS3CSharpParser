var _loc_3:* = 0;
        var _loc_4:* = 0;
        var _loc_5:* = Math.min(param1.t, this.t);
        while (_loc_3 < _loc_5)
        {
            
            _loc_4 = _loc_4 + (this.a[_loc_3] - param1.a[_loc_3]);
            param2.a[++_loc_3] = _loc_4 & DM;
            _loc_4 = _loc_4 >> DB;
        }
        if (param1.t < this.t)
        {
            _loc_4 = _loc_4 - param1.s;
            while (_loc_3 < this.t)
            {
                
                _loc_4 = _loc_4 + this.a[_loc_3];
                param2.a[++_loc_3] = _loc_4 & DM;
                _loc_4 = _loc_4 >> DB;
            }
            _loc_4 = _loc_4 + this.s;
        }
        else
        {
            _loc_4 = _loc_4 + this.s;
            while (_loc_3 < param1.t)
            {
                
                _loc_4 = _loc_4 - param1.a[_loc_3];
                param2.a[++_loc_3] = _loc_4 & DM;
                _loc_4 = _loc_4 >> DB;
            }
            _loc_4 = _loc_4 - param1.s;
        }
        param2.s = _loc_4 < 0 ? (-1) : (0);
        if (_loc_4 < -1)
        {
            param2.a[++_loc_3] = DV + _loc_4;
        }
        else if (_loc_4 > 0)
        {
            param2.a[++_loc_3] = _loc_4;
        }
        param2.t = _loc_3;
        param2.clamp();
        return;
    