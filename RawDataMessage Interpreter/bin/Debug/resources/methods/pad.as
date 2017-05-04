var _loc_2:* = 0;
        var _loc_3:* = 0;
        _loc_2 = this.blockSize - param1.length % this.blockSize;
        _loc_3 = 0;
        while (_loc_3 < _loc_2)
        {
            
            param1[param1.length] = _loc_2;
            _loc_3 = _loc_3 + 1;
        }
        return;
    