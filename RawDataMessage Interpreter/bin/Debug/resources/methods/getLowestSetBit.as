var _loc_1:* = 0;
        while (_loc_1 < this.t)
        {
            
            if (this.a[_loc_1] != 0)
            {
                return _loc_1 * DB + this.lbit(this.a[_loc_1]);
            }
            _loc_1++;
        }
        if (this.s < 0)
        {
            return this.t * DB;
        }
        return -1;
    