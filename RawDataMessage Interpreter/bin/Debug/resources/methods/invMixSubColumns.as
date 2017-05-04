var _loc_1:* = 0;
        this.tmp.length = 0;
        this.tmp[0] = XtimeE[this.state[0]] ^ XtimeB[this.state[1]] ^ XtimeD[this.state[2]] ^ Xtime9[this.state[3]];
        this.tmp[5] = Xtime9[this.state[0]] ^ XtimeE[this.state[1]] ^ XtimeB[this.state[2]] ^ XtimeD[this.state[3]];
        this.tmp[10] = XtimeD[this.state[0]] ^ Xtime9[this.state[1]] ^ XtimeE[this.state[2]] ^ XtimeB[this.state[3]];
        this.tmp[15] = XtimeB[this.state[0]] ^ XtimeD[this.state[1]] ^ Xtime9[this.state[2]] ^ XtimeE[this.state[3]];
        this.tmp[4] = XtimeE[this.state[4]] ^ XtimeB[this.state[5]] ^ XtimeD[this.state[6]] ^ Xtime9[this.state[7]];
        this.tmp[9] = Xtime9[this.state[4]] ^ XtimeE[this.state[5]] ^ XtimeB[this.state[6]] ^ XtimeD[this.state[7]];
        this.tmp[14] = XtimeD[this.state[4]] ^ Xtime9[this.state[5]] ^ XtimeE[this.state[6]] ^ XtimeB[this.state[7]];
        this.tmp[3] = XtimeB[this.state[4]] ^ XtimeD[this.state[5]] ^ Xtime9[this.state[6]] ^ XtimeE[this.state[7]];
        this.tmp[8] = XtimeE[this.state[8]] ^ XtimeB[this.state[9]] ^ XtimeD[this.state[10]] ^ Xtime9[this.state[11]];
        this.tmp[13] = Xtime9[this.state[8]] ^ XtimeE[this.state[9]] ^ XtimeB[this.state[10]] ^ XtimeD[this.state[11]];
        this.tmp[2] = XtimeD[this.state[8]] ^ Xtime9[this.state[9]] ^ XtimeE[this.state[10]] ^ XtimeB[this.state[11]];
        this.tmp[7] = XtimeB[this.state[8]] ^ XtimeD[this.state[9]] ^ Xtime9[this.state[10]] ^ XtimeE[this.state[11]];
        this.tmp[12] = XtimeE[this.state[12]] ^ XtimeB[this.state[13]] ^ XtimeD[this.state[14]] ^ Xtime9[this.state[15]];
        this.tmp[1] = Xtime9[this.state[12]] ^ XtimeE[this.state[13]] ^ XtimeB[this.state[14]] ^ XtimeD[this.state[15]];
        this.tmp[6] = XtimeD[this.state[12]] ^ Xtime9[this.state[13]] ^ XtimeE[this.state[14]] ^ XtimeB[this.state[15]];
        this.tmp[11] = XtimeB[this.state[12]] ^ XtimeD[this.state[13]] ^ Xtime9[this.state[14]] ^ XtimeE[this.state[15]];
        _loc_1 = 0;
        while (_loc_1 < 4 * Nb)
        {
            
            this.state[_loc_1] = InvSbox[this.tmp[_loc_1]];
            _loc_1 = _loc_1 + 1;
        }
        return;
    