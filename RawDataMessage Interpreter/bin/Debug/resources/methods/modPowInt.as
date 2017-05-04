var _loc_3:* = null;
        if (param1 < 256 || param2.isEven())
        {
            _loc_3 = new ClassicReduction(param2);
        }
        else
        {
            _loc_3 = new MontgomeryReduction(param2);
        }
        return this.exp(param1, _loc_3);
    