var _loc_2:* = null;
        var _loc_3:* = null;
        var _loc_4:* = 0;
        var _loc_5:* = 0;
        _loc_2 = getIV4d();
        _loc_3 = new ByteArray();
        _loc_4 = 0;
        while (_loc_4 < param1.length)
        {
            
            _loc_3.position = 0;
            _loc_3.writeBytes(param1, _loc_4, blockSize);
            key.decrypt(param1, _loc_4);
            _loc_5 = 0;
            while (_loc_5 < blockSize)
            {
                
                param1[_loc_4 + _loc_5] = param1[_loc_4 + _loc_5] ^ _loc_2[_loc_5];
                _loc_5 = _loc_5 + 1;
            }
            _loc_2.position = 0;
            _loc_2.writeBytes(_loc_3, 0, blockSize);
            _loc_4 = _loc_4 + blockSize;
        }
        padding.unpad(param1);
        return;
    