var _loc_1:* = 0;
        var _loc_2:* = this.s & DM;
        var _loc_3:* = 0;
        while (_loc_3 < this.t)
        {
            
            _loc_1 = _loc_1 + this.cbit(this.a[_loc_3] ^ _loc_2);
            _loc_3++;
        }
        return _loc_1;
    