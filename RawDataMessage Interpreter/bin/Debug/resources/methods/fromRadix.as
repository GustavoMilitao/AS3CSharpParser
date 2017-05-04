var _loc_9:* = 0;
        this.fromInt(0);
        var _loc_3:* = this.chunkSize(param2);
        var _loc_4:* = Math.pow(param2, _loc_3);
        var _loc_5:* = false;
        var _loc_6:* = 0;
        var _loc_7:* = 0;
        var _loc_8:* = 0;
        while (_loc_8 < param1.length)
        {
            
            _loc_9 = this.intAt(param1, _loc_8);
            if (_loc_9 < 0)
            {
                if (param1.charAt(_loc_8) == "-" && this.sigNum() == 0)
                {
                    _loc_5 = true;
                }
            }
            else
            {
                _loc_7 = param2 * _loc_7 + _loc_9;
                if (++_loc_6 >= _loc_3)
                {
                    this.dMultiply(_loc_4);
                    this.dAddOffset(_loc_7, 0);
                    ++_loc_6 = 0;
                    _loc_7 = 0;
                }
            }
            _loc_8++;
        }
        if (++_loc_6 > 0)
        {
            this.dMultiply(Math.pow(param2, _loc_6));
            this.dAddOffset(_loc_7, 0);
        }
        if (_loc_5)
        {
            this.ZERO.subTo(this, this);
        }
        return;
    