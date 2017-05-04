var _loc_4:* = 0;
        if (param1 <= 0)
        {
            return 0;
        }
        var _loc_2:* = DV % param1;
        var _loc_3:* = this.s < 0 ? ((param1 - 1)) : (0);
        if (this.t > 0)
        {
            if (_loc_2 == 0)
            {
                _loc_3 = this.a[0] % param1;
            }
            else
            {
                _loc_4 = this.t - 1;
                while (_loc_4 >= 0)
                {
                    
                    _loc_3 = (_loc_2 * _loc_3 + this.a[_loc_4]) % param1;
                    _loc_4 = _loc_4 - 1;
                }
            }
        }
        return _loc_3;
    