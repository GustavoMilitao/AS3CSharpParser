var _loc_8:* = 0;
        var _loc_4:* = param1.position;
        var _loc_5:* = param1.position + param2;
        var _loc_6:* = 0;
        var _loc_7:* = 8;
        this.t = 0;
        this.s = 0;
        while (--_loc_5 >= _loc_4)
        {
            
            _loc_8 = _loc_5 < param1.length ? (param1[_loc_5]) : (0);
            if (_loc_6 == 0)
            {
                var _loc_10:* = this;
                _loc_10.t = this.t + 1;
                this.t = this.t++;
                this.a[this.t] = _loc_8;
            }
            else if (_loc_6 + _loc_7 > DB)
            {
                this.a[(this.t - 1)] = this.a[(this.t - 1)] | (_loc_8 & (1 << DB - _loc_6) - 1) << _loc_6;
                var _loc_10:* = this;
                _loc_10.t = this.t + 1;
                this.t = this.t++;
                this.a[this.t] = _loc_8 >> DB - _loc_6;
            }
            else
            {
                this.a[(this.t - 1)] = this.a[(this.t - 1)] | _loc_8 << _loc_6;
            }
            _loc_6 = _loc_6 + _loc_7;
            if (_loc_6 >= DB)
            {
                _loc_6 = _loc_6 - DB;
            }
        }
        if (!param3 && (param1[0] & 128) == 128)
        {
            this.s = -1;
            if (_loc_6 > 0)
            {
                this.a[(this.t - 1)] = this.a[(this.t - 1)] | (1 << DB - _loc_6) - 1 << _loc_6;
            }
        }
        this.clamp();
        param1.position = Math.min(_loc_4 + param2, param1.length);
        return;
    