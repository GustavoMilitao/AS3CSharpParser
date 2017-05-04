var _loc_2:* = 0;
        var _loc_3:* = 0;
        var _loc_4:* = 0;
        _loc_2 = param1.length % this.blockSize;
        if (_loc_2 != 0)
        {
            throw new Error("PKCS#5::unpad: ByteArray.length isn\'t a multiple of the blockSize");
        }
        _loc_2 = param1[(param1.length - 1)];
        _loc_3 = _loc_2;
        while (_loc_3 > 0)
        {
            
            _loc_4 = param1[(param1.length - 1)];
            var _loc_5:* = param1;
            var _loc_6:* = _loc_5.length - 1;
            _loc_5.length = _loc_6;
            if (_loc_2 != _loc_4)
            {
                throw new Error("PKCS#5:unpad: Invalid padding value. expected [" + _loc_2 + "], found [" + _loc_4 + "]");
            }
            _loc_3 = _loc_3 - 1;
        }
        return;
    