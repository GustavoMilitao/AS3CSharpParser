var _loc_3:* = 0;
        _loc_3 = param1;
        while (_loc_3 < this.t)
        {
            
            param2.a[_loc_3 - param1] = this.a[_loc_3];
            _loc_3++;
        }
        param2.t = Math.max(this.t - param1, 0);
        param2.s = this.s;
        return;
    