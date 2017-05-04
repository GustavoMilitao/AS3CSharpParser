var _loc_2:* = 0;
        var _loc_4:* = 0;
        var _loc_5:* = 0;
        var _loc_3:* = this.abs();
        if (_loc_3.t == 1 && _loc_3.a[0] <= lowprimes[(lowprimes.length - 1)])
        {
            _loc_2 = 0;
            while (_loc_2 < lowprimes.length)
            {
                
                if (_loc_3[0] == lowprimes[_loc_2])
                {
                    return true;
                }
                _loc_2++;
            }
            return false;
        }
        if (_loc_3.isEven())
        {
            return false;
        }
        _loc_2 = 1;
        while (_loc_2 < lowprimes.length)
        {
            
            _loc_4 = lowprimes[_loc_2];
            _loc_5 = _loc_2 + 1;
            while (_loc_5 < lowprimes.length && _loc_4 < lplim)
            {
                
                _loc_4 = _loc_4 * lowprimes[_loc_5++];
            }
            _loc_4 = _loc_3.modInt(_loc_4);
            while (_loc_2 < _loc_5)
            {
                
                if (_loc_4 % lowprimes[_loc_2++] == 0)
                {
                    return false;
                }
            }
        }
        return _loc_3.millerRabin(param1);
    