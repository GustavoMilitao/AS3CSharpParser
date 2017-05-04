var _loc_1:* = new BigInteger();
        var _loc_2:* = 0;
        while (_loc_2 < this.t)
        {
            
            _loc_1[_loc_2] = DM & ~this.a[_loc_2];
            _loc_2++;
        }
        _loc_1.t = this.t;
        _loc_1.s = ~this.s;
        return _loc_1;
    