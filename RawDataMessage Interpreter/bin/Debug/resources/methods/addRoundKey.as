var _loc_3:* = 0;
        _loc_3 = 0;
        while (_loc_3 < 16)
        {
            
            this.state[_loc_3] = this.state[_loc_3] ^ param1[_loc_3 + param2];
            _loc_3 = _loc_3 + 1;
        }
        return;
    