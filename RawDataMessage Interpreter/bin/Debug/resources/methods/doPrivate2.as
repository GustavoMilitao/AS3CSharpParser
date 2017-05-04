if (this.p == null && this.q == null)
        {
            return param1.modPow(this.d, this.n);
        }
        var _loc_2:* = param1.mod(this.p).modPow(this.dmp1, this.p);
        var _loc_3:* = param1.mod(this.q).modPow(this.dmq1, this.q);
        while (_loc_2.compareTo(_loc_3) < 0)
        {
            
            _loc_2 = _loc_2.add(this.p);
        }
        var _loc_4:* = _loc_2.subtract(_loc_3).multiply(this.coeff).mod(this.p).multiply(this.q).add(_loc_3);
        return _loc_2.subtract(_loc_3).multiply(this.coeff).mod(this.p).multiply(this.q).add(_loc_3);
    