var _loc_1:* = 0;
        var _loc_2:* = 0;
        var _loc_3:* = 0;
        var _loc_4:* = 0;
        var _loc_5:* = 0;
        var _loc_6:* = 0;
        var _loc_7:* = 0;
        _loc_7 = this.key.length / 4;
        this.Nr = _loc_7 + 6;
        _loc_6 = _loc_7;
        while (_loc_6 < Nb * (this.Nr + 1))
        {
            
            _loc_1 = this.key[4 * _loc_6 - 4];
            _loc_2 = this.key[4 * _loc_6 - 3];
            _loc_3 = this.key[4 * _loc_6 - 2];
            _loc_4 = this.key[4 * _loc_6 - 1];
            if (!(_loc_6 % _loc_7))
            {
                _loc_5 = _loc_4;
                _loc_4 = Sbox[_loc_1];
                _loc_1 = Sbox[_loc_2] ^ Rcon[_loc_6 / _loc_7];
                _loc_2 = Sbox[_loc_3];
                _loc_3 = Sbox[_loc_5];
            }
            else if (_loc_7 > 6 && _loc_6 % _loc_7 == 4)
            {
                _loc_1 = Sbox[_loc_1];
                _loc_2 = Sbox[_loc_2];
                _loc_3 = Sbox[_loc_3];
                _loc_4 = Sbox[_loc_4];
            }
            this.key[4 * _loc_6 + 0] = this.key[4 * _loc_6 - 4 * _loc_7 + 0] ^ _loc_1;
            this.key[4 * _loc_6 + 1] = this.key[4 * _loc_6 - 4 * _loc_7 + 1] ^ _loc_2;
            this.key[4 * _loc_6 + 2] = this.key[4 * _loc_6 - 4 * _loc_7 + 2] ^ _loc_3;
            this.key[4 * _loc_6 + 3] = this.key[4 * _loc_6 - 4 * _loc_7 + 3] ^ _loc_4;
            _loc_6 = _loc_6 + 1;
        }
        return;
    