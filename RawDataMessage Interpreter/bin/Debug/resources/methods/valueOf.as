if (this.s == -1)
        {
            return -this.negate().valueOf();
        }
        var _loc_1:* = 1;
        var _loc_2:* = 0;
        var _loc_3:* = 0;
        while (_loc_3 < this.t)
        {
            
            _loc_2 = _loc_2 + this.a[_loc_3] * _loc_1;
            _loc_1 = _loc_1 * DV;
            _loc_3 = _loc_3 + 1;
        }
        return _loc_2;
    