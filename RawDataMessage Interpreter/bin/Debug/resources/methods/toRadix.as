if (this.sigNum() == 0 || param1 < 2 || param1 > 32)
        {
            return "0";
        }
        var _loc_2:* = this.chunkSize(param1);
        var _loc_3:* = Math.pow(param1, _loc_2);
        var _loc_4:* = nbv(_loc_3);
        var _loc_5:* = this.nbi();
        var _loc_6:* = this.nbi();
        var _loc_7:* = "";
        this.divRemTo(_loc_4, _loc_5, _loc_6);
        while (_loc_5.sigNum() > 0)
        {
            
            _loc_7 = (_loc_3 + _loc_6.intValue()).toString(param1).substr(1) + _loc_7;
            _loc_5.divRemTo(_loc_4, _loc_5, _loc_6);
        }
        return _loc_6.intValue().toString(param1) + _loc_7;
    