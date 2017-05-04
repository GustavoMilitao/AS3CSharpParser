var _loc_2:* = this.nbi();
        this.abs().divRemTo(param1, null, _loc_2);
        if (this.s < 0 && _loc_2.compareTo(ZERO) > 0)
        {
            param1.subTo(_loc_2, _loc_2);
        }
        return _loc_2;
    