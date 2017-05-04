var _loc_2:* = Math.floor(param1 / DB);
        if (_loc_2 >= this.t)
        {
            return this.s != 0;
        }
        return (this.a[_loc_2] & 1 << param1 % DB) != 0;
    