var _loc_4:* = 0;
        var _loc_2:* = this.abs();
        var _loc_5:* = 2 * _loc_2.t;
        param1.t = 2 * _loc_2.t;
        var _loc_3:* = _loc_5;
        while (--_loc_3 >= 0)
        {
            
            param1.a[_loc_3] = 0;
        }
        --_loc_3 = 0;
        while (_loc_3 < (_loc_2.t - 1))
        {
            
            _loc_4 = _loc_2.am(--_loc_3, _loc_2.a[--_loc_3], param1, 2 * _loc_3, 0, 1);
            var _loc_5:* = param1.a[_loc_3 + _loc_2.t] + _loc_2.am((_loc_3 + 1), 2 * _loc_2.a[_loc_3], param1, 2 * _loc_3 + 1, _loc_4, _loc_2.t - _loc_3 - 1);
            param1.a[_loc_3 + _loc_2.t] = param1.a[_loc_3 + _loc_2.t] + _loc_2.am((_loc_3 + 1), 2 * _loc_2.a[_loc_3], param1, 2 * _loc_3 + 1, _loc_4, _loc_2.t - _loc_3 - 1);
            if (_loc_5 >= DV)
            {
                param1.a[_loc_3 + _loc_2.t] = param1.a[_loc_3 + _loc_2.t] - DV;
                param1.a[_loc_3 + _loc_2.t + 1] = 1;
            }
            _loc_3++;
        }
        if (param1.t > 0)
        {
            param1.a[(param1.t - 1)] = param1.a[(param1.t - 1)] + _loc_2.am(_loc_3, _loc_2.a[_loc_3], param1, 2 * _loc_3, 0, 1);
        }
        param1.s = 0;
        param1.clamp();
        return;
    