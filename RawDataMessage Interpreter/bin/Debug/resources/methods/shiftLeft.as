var _loc_2:* = new BigInteger();
        if (param1 < 0)
        {
            this.rShiftTo(-param1, _loc_2);
        }
        else
        {
            this.lShiftTo(param1, _loc_2);
        }
        return _loc_2;
    