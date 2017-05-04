var _loc_1:* = "N=" + this.n.toString(16) + "\n" + "E=" + this.e.toString(16) + "\n";
        if (this.canDecrypt)
        {
            _loc_1 = _loc_1 + ("D=" + this.d.toString(16) + "\n");
            if (this.p != null && this.q != null)
            {
                _loc_1 = _loc_1 + ("P=" + this.p.toString(16) + "\n");
                _loc_1 = _loc_1 + ("Q=" + this.q.toString(16) + "\n");
                _loc_1 = _loc_1 + ("DMP1=" + this.dmp1.toString(16) + "\n");
                _loc_1 = _loc_1 + ("DMQ1=" + this.dmq1.toString(16) + "\n");
                _loc_1 = _loc_1 + ("IQMP=" + this.coeff.toString(16) + "\n");
            }
        }
        return _loc_1;
    