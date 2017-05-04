var _loc_3:* = this.abs();
        var _loc_4:* = param1.abs();
        var _loc_5:* = _loc_3.t;
        param2.t = _loc_5 + _loc_4.t;
        while (--_loc_5 >= 0)
        {
            
            param2.a[_loc_5] = 0;
        }
        --_loc_5 = 0;
        while (_loc_5 < _loc_4.t)
        {
            
            param2.a[--_loc_5 + _loc_3.t] = _loc_3.am(0, _loc_4.a[_loc_5], param2, _loc_5, 0, _loc_3.t);
            _loc_5++;
        }
        param2.s = 0;
        param2.clamp();
        if (this.s != param1.s)
        {
            ZERO.subTo(param2, param2);
        }
        return;
    