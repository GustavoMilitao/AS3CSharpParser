var _loc_4:* = 0;
        var _loc_1:* = this.t;
        var _loc_2:* = new ByteArray();
        _loc_2[0] = this.s;
        var _loc_3:* = DB - _loc_1 * DB % 8;
        var _loc_5:* = 0;
        if (_loc_1-- > 0)
        {
            var _loc_6:* = this.a[_loc_1] >> _loc_3;
            _loc_4 = this.a[_loc_1] >> _loc_3;
            if (_loc_3 < DB && _loc_6 != (this.s & DM) >> _loc_3)
            {
                _loc_2[++_loc_5] = _loc_4 | this.s << DB - _loc_3;
            }
            while (_loc_1 >= 0)
            {
                
                if (_loc_3 < 8)
                {
                    _loc_4 = (this.a[_loc_1] & (1 << _loc_3) - 1) << 8 - _loc_3;
                    var _loc_6:* = _loc_3 + (DB - 8);
                    _loc_3 = _loc_3 + (DB - 8);
                    _loc_4 = _loc_4 | this.a[--_loc_1] >> _loc_6;
                }
                else
                {
                    var _loc_6:* = _loc_3 - 8;
                    _loc_3 = _loc_3 - 8;
                    _loc_4 = this.a[--_loc_1] >> _loc_6 & 255;
                    if (_loc_3 <= 0)
                    {
                        _loc_3 = _loc_3 + DB;
                        _loc_1 = _loc_1 - 1;
                    }
                }
                if ((_loc_4 & 128) != 0)
                {
                    _loc_4 = _loc_4 | -256;
                }
                if (_loc_5 == 0 && (this.s & 128) != (_loc_4 & 128))
                {
                    _loc_5++;
                }
                if (_loc_5 > 0 || _loc_4 != this.s)
                {
                    _loc_2[++_loc_5] = _loc_4;
                }
            }
        }
        return _loc_2;
    