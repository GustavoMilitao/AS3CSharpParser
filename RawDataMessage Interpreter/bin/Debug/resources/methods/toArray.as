var _loc_2:* = 8;
        var _loc_3:* = (1 << 8) - 1;
        var _loc_4:* = 0;
        var _loc_5:* = this.t;
        var _loc_6:* = DB - _loc_5 * DB % _loc_2;
        var _loc_7:* = false;
        var _loc_8:* = 0;
        if (_loc_5-- > 0)
        {
            var _loc_9:* = this.a[_loc_5] >> _loc_6;
            _loc_4 = this.a[_loc_5] >> _loc_6;
            if (_loc_6 < DB && _loc_9 > 0)
            {
                _loc_7 = true;
                param1.writeByte(_loc_4);
                _loc_8++;
            }
            while (_loc_5 >= 0)
            {
                
                if (_loc_6 < _loc_2)
                {
                    _loc_4 = (this.a[_loc_5] & (1 << _loc_6) - 1) << _loc_2 - _loc_6;
                    var _loc_9:* = _loc_6 + (DB - _loc_2);
                    _loc_6 = _loc_6 + (DB - _loc_2);
                    _loc_4 = _loc_4 | this.a[--_loc_5] >> _loc_9;
                }
                else
                {
                    var _loc_9:* = _loc_6 - _loc_2;
                    _loc_6 = _loc_6 - _loc_2;
                    _loc_4 = this.a[--_loc_5] >> _loc_9 & _loc_3;
                    if (_loc_6 <= 0)
                    {
                        _loc_6 = _loc_6 + DB;
                        _loc_5 = _loc_5 - 1;
                    }
                }
                if (_loc_4 > 0)
                {
                    _loc_7 = true;
                }
                if (_loc_7)
                {
                    param1.writeByte(_loc_4);
                    _loc_8++;
                }
            }
        }
        return _loc_8;
    