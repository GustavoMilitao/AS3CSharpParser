if (this.t < 1)
        {
            return 0;
        }
        var _loc_1:* = this.a[0];
        if ((_loc_1 & 1) == 0)
        {
            return 0;
        }
        var _loc_2:* = _loc_1 & 3;
        _loc_2 = _loc_2 * (2 - (_loc_1 & 15) * _loc_2) & 15;
        _loc_2 = _loc_2 * (2 - (_loc_1 & 255) * _loc_2) & 255;
        _loc_2 = _loc_2 * (2 - ((_loc_1 & 65535) * _loc_2 & 65535)) & 65535;
        _loc_2 = _loc_2 * (2 - _loc_1 * _loc_2 % DV) % DV;
        return _loc_2 > 0 ? (DV - _loc_2) : (-_loc_2);
    