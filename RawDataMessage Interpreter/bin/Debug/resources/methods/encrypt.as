var _loc_2:* = null;
        var _loc_3:* = 0;
        var _loc_4:* = 0;
        padding.pad(param1);
        _loc_2 = getIV4e();
        _loc_3 = 0;
        while (_loc_3 < param1.length)
        {
            
            _loc_4 = 0;
            while (_loc_4 < blockSize)
            {
                
                param1[_loc_3 + _loc_4] = param1[_loc_3 + _loc_4] ^ _loc_2[_loc_4];
                _loc_4 = _loc_4 + 1;
            }
            key.encrypt(param1, _loc_3);
            _loc_2.position = 0;
            _loc_2.writeBytes(param1, _loc_3, blockSize);
            _loc_3 = _loc_3 + blockSize;
        }
        return;
    