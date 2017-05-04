if (param1 < 2)
        {
            return _SEXLXEXIWMG.nbv(1);
        }
        var _loc_3:* = new ByteArray();
        param2.nextBytes(_loc_3, param1 >> 3);
        _loc_3.position = 0;
        var _loc_4:* = new BigInteger(_loc_3, 0, true);
        _loc_4.primify(param1, 1);
        return _loc_4;
    