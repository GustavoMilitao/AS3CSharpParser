var qd:int;
        var m:* = param1;
        var q:* = param2;
        var r:* = param3;
        var pm:* = m.abs();
        if (pm.t <= 0)
        {
            return;
        }
        var pt:* = this.abs();
        if (pt.t < pm.t)
        {
            if (q != null)
            {
                q.fromInt(0);
            }
            if (r != null)
            {
                this.copyTo(r);
            }
            return;
        }
        if (r == null)
        {
            r = this.nbi();
        }
        var y:* = this.nbi();
        var ts:* = this.s;
        var ms:* = m.s;
        var nsh:* = DB - this.nbits(pm.a[(pm.t - 1)]);
        if (nsh > 0)
        {
            pm.lShiftTo(nsh, y);
            pt.lShiftTo(nsh, r);
        }
        else
        {
            pm.copyTo(y);
            pt.copyTo(r);
        }
        var ys:* = y.t;
        var y0:* = y.a[(ys - 1)];
        if (y0 == 0)
        {
            return;
        }
        var yt:* = y0 * (1 << F1) + (ys > 1 ? (y.a[ys - 2] >> F2) : (0));
        var d1:* = FV / yt;
        var d2:* = (1 << F1) / yt;
        var e:* = 1 << F2;
        var i:* = r.t;
        var j:* = i - ys;
        var t:* = q == null ? (this.nbi()) : (q);
        y.dlShiftTo(j, t);
        if (r.compareTo(t) >= 0)
        {
            var _loc_6:* = r;
            _loc_6.t = _loc_6.t++;
            r.a[_loc_6.t] = 1;
            _loc_6.subTo(t, r);
        }
        ONE.dlShiftTo(ys, t);
        t.subTo(y, y);
        while (_loc_7.t < ys)
        {
            
            var _loc_6:* = 0;
            var _loc_7:* = y;
            var _loc_5:* = new XMLList("");
            for each (_loc_8 in _loc_7)
            {
                
                var _loc_9:* = _loc_7[_loc_6];
                with (_loc_7[_loc_6])
                {
                    var _loc_10:* = y;
                    var _loc_11:* = _loc_7.t + 1;
                    _loc_10.t = _loc_11;
                    if (0)
                    {
                        _loc_5[_loc_6] = _loc_8;
                    }
                }
            }
        }
        do
        {
            
            i = (i - 1);
            qd = r.a[(i - 1)] == y0 ? (DM) : (Number(r.a[i]) * d1 + (Number(r.a[(i - 1)]) + e) * d2);
            var _loc_5:* = r.a[i] + _loc_7.am(0, qd, r, j, 0, ys);
            r.a[i] = r.a[i] + _loc_7.am(0, qd, r, j, 0, ys);
            if (_loc_5 < qd)
            {
                _loc_7.dlShiftTo(j, t);
                r.subTo(t, r);
                do
                {
                    
                    r.subTo(t, r);
                    qd = (qd - 1);
                }while (r.a[i] < (qd - 1))
            }
            j = (j - 1);
        }while ((j - 1) >= 0)
        if (q != null)
        {
            r.drShiftTo(ys, q);
            if (ts != ms)
            {
                ZERO.subTo(q, q);
            }
        }
        r.t = ys;
        r.clamp();
        if (nsh > 0)
        {
            r.rShiftTo(nsh, r);
        }
        if (ts < 0)
        {
            ZERO.subTo(r, r);
        }
        return;
    